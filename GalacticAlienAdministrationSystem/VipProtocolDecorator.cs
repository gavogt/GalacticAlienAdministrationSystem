using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class VipProtocolDecorator : BookingDecorator
    {
        public VipProtocolDecorator(Booking booking) : base(booking)
        {
        }

        public override string GetDetails()
        {
            return ($"{booking.GetDetails()}, This is a decorator, Alien is a VIP");
        }
    }
}
