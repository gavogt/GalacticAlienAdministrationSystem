using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Administrator
    {
        private int _id;
        private bool _isAuthenticated;

        public Administrator(int id)
        {
            _id = id;
            Authenticate(_id);

        }

        enum VerifiedAdministrator
        {
            id1 = 1,
            id2 = 2

        }

        public bool Authenticate(int id)
        {
            if (id == (int)VerifiedAdministrator.id1 || id == (int)VerifiedAdministrator.id2)
            {
                _isAuthenticated = true;
            }
            return _isAuthenticated;
        }

        public void ManualApproveBooking(IFacility facility, Booking booking)
        {
            if (!facility.IsApproved() && _isAuthenticated)
            {
                booking.bookingStatus = "Approved";
                Console.WriteLine($"Booking has been manually set to {booking.bookingStatus} by Admin:{_id}");
            }
            else
            {
                Console.WriteLine("Cannot approve booking manually");
            }
        }
    }
}
