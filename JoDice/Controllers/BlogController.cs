using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Korzh.EasyQuery.Linq;
using JoDice.Models;

namespace JoDice.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Index()
        {
          return View();
        }
    }
}
