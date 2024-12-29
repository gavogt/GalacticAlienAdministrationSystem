using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class ManualApprovalStrategy : IApprovalBookingStrategyPattern
    {
        public string ApproveBooking(Booking booking)
        {
            int input = 0;
            Console.WriteLine("1. Approved");
            Console.WriteLine("2. Not approved");
            Console.Write("Enter your selection ");
            while (input < 1 || input > 2)
            {
                int.TryParse(Console.ReadLine(), out input);

                if (input == 1)
                {
                    return booking.bookingStatus = "Approved";
                }
                if (input == 2)
                {
                    return booking.bookingStatus = "Not approved";
                }
            }
            return "Error";
        }
    }
}
