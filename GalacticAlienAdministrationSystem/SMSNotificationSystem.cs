using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class SMSNotificationSystem : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"SMS update of booking. Booking ID: {booking.bookingID} and Booking Status {booking.bookingStatus}");
        }
    }
}
