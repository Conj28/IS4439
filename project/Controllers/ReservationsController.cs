using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class ReservationsController : Controller
    {
        public IActionResult Index()
        {
         
            DB db = DB.Restore();
            ViewBag.bookings = db.booking;
            ViewBag.Title = "All Reservations";

            return View();

        }

        
        public IActionResult Date(String dt)
        {

            DateTime date = Convert.ToDateTime(dt);

            ViewBag.Title = string.Format("All Reservations on {0}", date.ToString("dd/MM/yyyy"));
            DB db = DB.Restore();
            List<Booking> bookingDate = db.GetBookingByDate(dt);
            if(bookingDate.Count == 0)
            {
                ViewBag.Message = "The are no bookings for the date " + dt + " please try another date";
                ViewBag.Title = "Not Found";
                return View("NotFound");
            }

            ViewBag.Bookings = bookingDate;

            return View();
        }

        [Route("Info/{Id}")]
        public IActionResult BookingInfo(int Id)
        {
            ViewBag.Title = string.Format("Details of Booking Number {0}", Id);
            DB db = DB.Restore();
            Booking bookingInfo = db.GetBooking(Id);
              if (bookingInfo == null)
               {
                   ViewBag.Message = "The are no bookings for the id " + Id + " please try another date";
                ViewBag.Title = "Not Found";
                return View("NotFound");
               }

            

            return View(bookingInfo);
        }

        [Route("Delete/{id}")]
        public IActionResult Delete(int Id)
        {
            
            DB.RemoveBooking(Id);

            DB db = DB.Restore();
            ViewBag.bookings = db.booking;
            ViewBag.Title = "Booking ID: " +Id+ " Removed" ;

            return RedirectToAction("Index");
        }

    }
}