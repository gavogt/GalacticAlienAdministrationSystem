using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class TurnOffBookingCommand : ICommand
    {
        Booking booking;

        public TurnOffBookingCommand(Booking booking)
        {
            this.booking = booking;
        }

        public void Execute()
        {
            booking.RemoveBooking();
        }

        public void Undo()
        {

            booking.ScheduleBooking();

        }
    }
}
