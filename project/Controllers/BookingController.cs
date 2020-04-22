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
            ViewBag.Title = "Book a Table";
            return View();
        }

        //POST : Booking/
        [HttpPost]
        public IActionResult Index(Booking b)
        {
            if (ModelState.IsValid)
            {
                if (b.BookingDate < DateTime.Now)
                {

                    //make sure the users previously selected time and service are selected
                    ViewBag.Service = b.Service;
                    ViewBag.ServiceTime = b.Time;


                    ViewBag.ErrorMessage = "Booking date must be in the future";
                    ViewBag.Title = "Book a Table";

                    return View();
                }

                Booking newBooking = DB.AddBooking(b);
                ViewBag.Title = "Booking Confirmation";
                return View(newBooking);

            }
            else
            ViewBag.Service = b.Service;
            ViewBag.ServiceTime = b.Time;
            ViewBag.Title = "Book a Table";
            return View();
        }

    }
}