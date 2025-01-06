using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    internal class BookingFacadeScheduler : IFacadeScheduling
    {
        public void CreateBookingSchedule()
        {
            Booking booking = null;
            BookingManager bookingManager = new BookingManager();
            MenuDisplay.BookingMenu(bookingManager, booking);

            
        }

        public bool IsAvailable(Booking booking)
        {
            if(booking.bookingStatus == "Available")
            {
                return true;
            }

            return false;
        }
    }
}
