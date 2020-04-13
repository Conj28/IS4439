using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class BookingController : Controller
    {
        // Get:/Booking/
        public IActionResult Index()
        {
            return View();
        }

        //POST : Booking/
        [HttpPost]
        public IActionResult Index(Booking b)
        {
            if (ModelState.IsValid)
            {
               if(b.BookingDate < DateTime.Now)
                {
                    ViewBag.ErrorMessage = "Booking date must be in the future";
                    return View();
                }
           
                Booking newBooking = DB.AddBooking(b);
                return View(newBooking);

            }
            else
                return View();
        }

    }
}