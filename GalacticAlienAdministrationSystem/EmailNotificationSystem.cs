using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class EmailNotificationSystem : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"Email notification: Booking {booking.bookingID} has been {booking.bookingStatus}.");
        }
    }
}
