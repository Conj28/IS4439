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

        //Get api/{id}
        [Route("{Id}")]
        public IActionResult GetBooking(int id)
        {
            DB db = DB.Restore();
            Booking b = db.GetBooking(id);
            if(b == null)
                return NotFound();
            return new ObjectResult(b);
        }


        // GET: date/{date}
        [Route("date/{date}")]
        [HttpGet]
        public IActionResult GetBookingDate(String date)
        {
            DB db = DB.Restore();
            List<Booking> bookingDate = db.GetBookingByDate(date);
            if (bookingDate.Count == 0)
            {
                return NotFound();
            }
            return new ObjectResult(bookingDate);
        }



        // POST
        [HttpPost]
        public IActionResult NewBooking([FromBody] Booking b)
        {

            Booking newBooking = new Booking();
            newBooking = DB.AddBooking(b);
            if (newBooking == null)
            {
                return NotFound();
            }
            //add Booking returns booking object with auto Increment 
          return new ObjectResult(newBooking);
          
        }


        //Put
        [HttpPut]
        public IActionResult Update([FromBody] Booking b)
        {
            string message = DB.RemoveBooking(b.BookingNum);
            if (b == null)
            {
                return BadRequest();
            }
            DB.UpdateBooking(b);
            return CreatedAtAction(nameof(GetBooking), new { BookingNum = b.BookingNum }, b);
        }


        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //int num = Int32.Parse(id);
            string message = DB.RemoveBooking(id);
            if (message == "Error")
            {
                return NotFound();
            }
            return new NoContentResult();
        }
    }
}
