using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class TurnOnBookingCommand: ICommand
    {
        Booking booking;
        public TurnOnBookingCommand(Booking booking)
        {
            this.booking = booking;

        }

        public void Execute()
        {
            booking.ScheduleBooking();
        }

        public void Undo()
        {
            booking.RemoveBooking();
        }
    }
}
