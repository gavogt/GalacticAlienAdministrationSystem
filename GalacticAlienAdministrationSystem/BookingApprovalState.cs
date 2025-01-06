using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingApprovalState : IBookingStatus
    {
        public void Approve()
        {
            Console.WriteLine("Booking approved");
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Deny()
        {
            throw new NotImplementedException();
        }
    }
}
