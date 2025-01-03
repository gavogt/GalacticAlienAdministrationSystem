using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class RemoveBookingCommand : ICommand
    {
        Booking booking;
        BookingManager bookingManager;
        public RemoveBookingCommand(Booking booking, BookingManager bookingManager)
        {
            this.booking = booking;
            this.bookingManager = bookingManager;

        }

        public void Execute()
        {
            bookingManager.RemoveBookingFromList(booking);
            Console.WriteLine($"Booking {booking.bookingID} removed");
            MenuDisplay.PressAnyKey();
        }

        public void Undo()
        {
            bookingManager.AddBookingToAList(booking);
            Console.WriteLine($"Booking {booking.bookingID} added");
            MenuDisplay.PressAnyKey();

        }
    }
}
