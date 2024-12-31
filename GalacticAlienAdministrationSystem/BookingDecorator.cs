using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public abstract class BookingDecorator : IDecorator
    {
        public Booking booking;

        protected BookingDecorator(Booking booking)
        {
            this.booking = booking;
        }
        public abstract string GetDetails();
    }
}
