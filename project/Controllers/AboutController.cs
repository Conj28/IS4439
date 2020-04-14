using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult Review()
        {
            ViewBag.Title = "Reviews";
            return View();
        }

        public IActionResult Team()
        {
            ViewBag.Title = "The Team";
            return View();
        }
    }
}