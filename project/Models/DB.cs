using System;
using System.Collections.Generic;
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

            int nextId = 1;

            //get the lst id
            if (db.booking.Count > 0)
            {
                var lastItem = db.booking[db.booking.Count - 1];
                int lastId = lastItem.BookingNum;
                nextId = lastId + 1;
            }


            Booking NewBooking = new Booking();

            NewBooking = b;
            NewBooking.BookingNum = nextId;
            db.booking.Add(b);

            db.Save();
         
            //does not retuen message as it must return the generated booing number to be displayed to user
            return NewBooking;
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
            DateTime date = Convert.ToDateTime(dt);

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

        public Booking GetBookingById(int id)
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
    }

        public static string RemoveBooking(int Id)
        {
            DB db = Restore();
            Booking b = db.GetBookingById(Id);
            if(b == null)
            {
                return ("Error");
            }
            db.booking.Remove(b);
            string message = db.Save();
            if (message == "Ok")
                message = string.Format("Boooking ID:{0} has been removed", b.BookingNum);
            return message;
        }

        public static int GetLastId()
        {
            DB db = Restore();
              
            int nextId = 1;

            // get the lst id
            if (db.booking.Count > 0)
             {
                 var lastItem = db.booking[db.booking.Count - 1];
                 int lastId = lastItem.BookingNum;
                 nextId = lastId + 1;
             }

            return nextId;
        }
    }

}