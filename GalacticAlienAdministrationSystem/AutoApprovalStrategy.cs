using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class AutoApprovalStrategy : IApprovalBookingStrategyPattern
    {
        public string ApproveBooking(Booking booking)
        {
            return booking.bookingStatus = "Approved";

        }
    }
}
