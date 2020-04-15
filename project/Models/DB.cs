using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

namespace project.Models
{
    public class DB
    {
        public DB()
        {
        }
        public List<Booking> booking { get; set; }

        public string Save()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(DB));
                FileStream s = new FileStream("App_Data/db.xml", FileMode.Create);
                ser.Serialize(s, this);
                s.Flush();
                s.Dispose();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Ok";
        }
        public static DB Restore()
        {
            DB db;
            XmlSerializer ser = new XmlSerializer(typeof(DB));
            FileStream s = new FileStream("App_Data/db.xml", FileMode.Open);
            db = (DB)ser.Deserialize(s);
            s.Dispose();
            return db;

        }
        public static Booking AddBooking(Booking b)
        {
            DB db = Restore();

            Booking NewBooking = new Booking();


            NewBooking = b;

            //Call function to auto increment Value
            NewBooking.BookingNum = GetLastId();
            db.booking.Add(NewBooking);

            db.Save();
            return NewBooking;


        }


        public static Booking UpdateBooking(Booking b)
        {
            DB db = Restore();

            db.booking.Add(b);
            db.Save();
            //does not retuen message as it must return the generated booing number to be displayed to user
            return b;


        }

        public List<Booking> GetBookingByName(string name)
        {
            List<Booking> booking_list = new List<Booking>();
            DB db = Restore();
            foreach (Booking b in db.booking)
            {
                if (b.Name == name)
                {
                    booking_list.Add(b);
                }
            }
            return booking_list;

        }

        public List<Booking> GetBookingByDate(String dt)
        {
           // DateTime date = Convert.ToDateTime(dt);
            DateTime date = DateTime.ParseExact(dt, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<Booking> booking_list = new List<Booking>();
            DB db = Restore();
            foreach (Booking b in db.booking)
            {
                if (b.BookingDate == date)
                {
                    booking_list.Add(b);
                }
            }
            return booking_list;

        }

        /*   public Booking GetBookingById(int id)
           {
               DB db = Restore();
               Booking foundBooking = new Booking();

               foreach (Booking b in db.booking)
               {
                   if (b.BookingNum == id)
                   {
                       //if it matches assign the objec to this object
                       foundBooking = b;
                   }
   }
               return foundBooking;
       } */

        public static string RemoveBooking(int Id)
        {
            DB db = Restore();
            Booking b = db.GetBooking(Id);
            if (b == null)
            {
                return ("Error");
            }
            db.booking.Remove(b);
            string message = db.Save();
            if (message == "Ok")
                message = string.Format("Boooking ID:{0} has been removed", b.BookingNum);
            return message;
        }

        public Booking GetBooking(int id)
        {
            Booking booking = null;
            foreach (Booking b in this.booking)
            {
                if (b.BookingNum == id)
                {
                    booking = b;
                }
            }
            return booking;
        }

        public static int GetLastId()
        {
            DB db = Restore();

            //cnt only use the last record as a PUT will mess up order
            //int nextId = 1;

           
            /*   if (db.booking.Count > 0)
                {
                    var lastItem = db.booking[db.booking.Count - 1];
                    int lastId = lastItem.BookingNum;
                    nextId = lastId + 1;
                }
               foreach(Booking b in db.booking)
               {
                   if(nextId == b.BookingNum)
                   {
                       nextId = b.BookingNum + 1;
                   }
               } */

            int HighestNum = 1;

            //get the highest ID and add one
            foreach (Booking b in db.booking)
            {
                if (HighestNum < b.BookingNum)
                    HighestNum = b.BookingNum;
            }
            int nextNum = HighestNum + 1;
            return nextNum;
        }


    }


}
