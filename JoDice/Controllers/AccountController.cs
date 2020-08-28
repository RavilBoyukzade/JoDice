using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AutoMapper;
using JoDice.Models.Account;
using Korzh.EasyQuery;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AuthRepository;

namespace JoDice.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;


        public AccountController(IMapper mapper,
                                 IAuthRepository authRepository
                                 )
        {
            _mapper = mapper;
            _authRepository = authRepository;

        }

        public IActionResult RegisterAccount()
        {
            return View();
        }

        public IActionResult LoginAccount()
        {
            return View();
        }
        [HttpPost]

        public IActionResult RegisterAccount(RegisterViewModel register)
        {
            var checkUser = _authRepository.CheckEmail(register.Email);

            if (checkUser)
            {
                ModelState.AddModelError("Email", "Bu e-poçt artıq var");
            }

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterViewModel, User>(register);
                user.Token = Guid.NewGuid().ToString();
                user.Status = true;
                _authRepository.Register(user);

                Response.Cookies.Delete("token");

                Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                if (user.UserList == Repository.Enums.UserList.JobSeeker)
                {
                    return RedirectToAction("index", "blog");
                }
                else
                {
                    return RedirectToAction("index", "home");
                }

            }

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginAccount(LoginViewModel login)
        {

            if (ModelState.IsValid)
            {
             
                var user = _authRepository.Login(login.Email, login.Password);

                if (user != null)
                {
                    user.Token = Guid.NewGuid().ToString();

                    _authRepository.UpdateToken(user.Id, user.Token);

                    Response.Cookies.Delete("token");

                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires =login.RememberMe ?  DateTime.Now.AddYears(1) : DateTime.Now.AddDays(1)
                    });

                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError("Login.Password", "E-poçt və ya şifrə yalnışdır");
            }
            return View(login);
            

           
        }

        public IActionResult Logout()
        {
            Request.Cookies.TryGetValue("token", out string token);

            User user = _authRepository.CheckByToken(token);

            _authRepository.UpdateToken(user.Id, null);

            return RedirectToAction("index", "home");
        }

        

      
    }
}
