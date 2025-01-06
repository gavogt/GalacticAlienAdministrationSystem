using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingClosedState : IBookingStatus
    {
        public void Approve()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            Console.WriteLine("Booking is closed");
        }

        public void Deny()
        {
            throw new NotImplementedException();
        }
    }
}
