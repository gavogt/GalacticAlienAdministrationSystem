using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingDeniedState : IBookingStatus
    {
        public void Approve()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Deny()
        {
            Console.WriteLine("Booking Denied");
        }
    }
}
