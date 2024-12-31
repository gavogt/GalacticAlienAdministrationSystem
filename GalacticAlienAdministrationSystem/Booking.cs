using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Booking : IDecorator
    {
        private static int _bookCounter = 1;
        public int bookingID { get; set; }
        private int _facilityID;
        private int _userID;
        public string bookingStatus = "Not set";
        public DateTime startDateTime;
        public DateTime endDateTime;

        public Booking(int facilityID, int userID)
        {
            bookingID = BookingCounter();
            _facilityID = facilityID;
            _userID = userID;
            bookingStatus = "Pending";
        }

        public Booking(int facilityID, int userID, DateTime startDateTime, DateTime endDateTime)
        {
            bookingID = BookingCounter();
            _facilityID = facilityID;
            _userID = userID;
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
        }

        public static int BookingCounter()
        {
            return _bookCounter++;
        }

        public override string ToString()
        {
            string update;
            update = $"Booking ID: {bookingID}\nFacility ID: {_facilityID}\nUser ID: {_userID}\nBooking Status: {bookingStatus}";
            return update;
        }

        public string GetDetails()
        {
            return "I am a base booking";
        }
    }
}
