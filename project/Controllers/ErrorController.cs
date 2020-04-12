using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Http(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("404");
            }
            return View();
        }
    }
}