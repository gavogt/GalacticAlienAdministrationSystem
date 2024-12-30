using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class CosmicEmail : IObserver
    {
        public void Update(Booking booking)
        {
            Console.WriteLine($"Cosmic email: Booking {booking.bookingID} has been {booking.bookingStatus}.");
        }
    }
}
