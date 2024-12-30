using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class GalacticTelepathyMessenger : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"Galactic Telepathy message Booking ID: {booking.bookingID} and Booking Status {booking.bookingStatus}");
        }
    }
}
