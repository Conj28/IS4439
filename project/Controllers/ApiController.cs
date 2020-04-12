using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/all
        [Route("all")]
        [HttpGet]
        public IEnumerable<Booking> GetAll()
        {
            DB db = DB.Restore();
            return db.booking;
        }

        // GET: date/{date}
        [Route("date/{date}")]
        [HttpGet]
        public IActionResult GetBookingDate(String date)
        {
            DB db = DB.Restore();
            List<Booking> bookingDate = db.GetBookingByDate(date);
            if(bookingDate.Count == 0)
            {
                return NotFound();
            }
            return new ObjectResult(bookingDate);
        }



        // GET: date/{date}
        [HttpPost]
        public IActionResult NewBooking([FromBody] Booking b)
        {
           
            Booking newBooking = new Booking();
            newBooking = DB.AddBooking(b);
            if (newBooking == null)
            {
                return NotFound();
            }
            return new ObjectResult(newBooking);
        }

      /*  // POST: api/Api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        } */

        

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string message = DB.RemoveBooking(id);
            if (message == "Error")
            {
                return NotFound();
            }
            return new NoContentResult();
        }
    }
}
