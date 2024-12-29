using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Booking
    {
        private static int _bookCounter = 1;
        public int bookingID { get; set; }
        private int _facilityID;
        private int _userID;
        public string bookingStatus = "Not set";

        public Booking(int facilityID, int userID)
        {
            IncreaseBookingID();
            _facilityID = facilityID;
            _userID = userID;
            bookingStatus = "Pending";
        }

        public void IncreaseBookingID()
        {
            bookingID = _bookCounter++;
        }

        public override string ToString()
        {
            string update;
            update = $"Booking ID: {bookingID}\nFacility ID: {_facilityID}\nUser ID: {_userID}\nBooking Status: {bookingStatus}";
            return update;
        }

        public void SetBookingStatus(string userType, int approvalSelection)
        {
            if (userType == "admin" || approvalSelection == 1)
            {
                bookingStatus = "Approved";
            }
            else if (userType == "admin" || approvalSelection == 2)
            {
                bookingStatus = "Under maintenance";
            }
            else if (userType == "user")
            {
                Console.WriteLine("Incorrect user type");

            }
            else
            {
                Console.WriteLine("Error");

            }
        }


    }
}
