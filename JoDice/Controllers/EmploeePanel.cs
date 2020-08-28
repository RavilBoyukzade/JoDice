using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JoDice.Controllers
{
    public class EmploeePanel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaffSingle()
        {
            return View();
        }

        public IActionResult EmploeeDashboard()
        {
            return View();
        }
        public IActionResult AddJob()
        {
            return View();
        }
        public IActionResult PostedJob()
        {
            return View();
        }
        public IActionResult UpdateProfile()
        {
            return View();
        }

        public IActionResult ChangePasword()
        {
            return View();
        }

    }
}
