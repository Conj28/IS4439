 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Booking
    {

        public Booking()
        {
        }

        public int BookingNum { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public String Service { get; set; }

        [Required]
        public String Time { get; set; }
        
       [Required]
       [Range(1,12)]
       public int NumGuests { get; set; }

        public bool Diet { get; set; }
    }
}
