using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class CreateBookingCommand : ICommand
    {

        public BookingManager bookingManager;
        public Booking booking;

        public CreateBookingCommand(Booking booking, BookingManager bookingManager)
        {
            this.booking = booking;
            this.bookingManager = bookingManager;

        }

        public void Execute()
        {

            bookingManager.AddBookingToAList(booking);
            Console.WriteLine($"Booking {booking.bookingID} added");
            MenuDisplay.PressAnyKey();

        }

        public void Undo()
        {
            bookingManager.RemoveBookingFromList(booking);
            Console.WriteLine($"Booking {booking.bookingID} removed");
            MenuDisplay.PressAnyKey();

        }
    }
}
