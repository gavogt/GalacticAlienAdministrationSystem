using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingManager
    {
        private List<Booking> _bookingsList = new List<Booking>();
        private Booking _bookings;
        private IApprovalBookingStrategyPattern _approvalBookingStrategyPattern;
        private Facility _facility;

        public BookingManager(Booking bookings, IApprovalBookingStrategyPattern approvalStrategy)
        {
            _approvalBookingStrategyPattern = approvalStrategy;
            _bookings = bookings;
        }

        public BookingManager()
        {
            
        }

        public void ApproveBooking(IFacility facility, Booking booking)
        {
            if (facility.IsApproved())
            {
                _approvalBookingStrategyPattern.ApproveBooking(booking);
            }
            else
            {
                Console.WriteLine("Facility is not approved. Cannot approve booking.");
            }
        }

        public void BookingCreateApprovalCheck()
        {
            var facility = MenuDisplay.MenuFacilityCreate();
            Booking bookings = new Booking(10, 10, DateTime.Now, DateTime.Now.AddHours(1));
            var approvalPattern = ReturnApprovalPattern();
            BookingManager bookingManager = new BookingManager(bookings, approvalPattern);
            // bookingManager.ApproveBooking(facility, bookings);
            Administrator admin = new Administrator(1);
            admin.ManualApproveBooking(facility, bookings);
            Console.WriteLine($"Booking {bookings.bookingID} has status {bookings.bookingStatus} for {bookings.startDateTime} till {bookings.endDateTime} .");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public IApprovalBookingStrategyPattern ReturnApprovalPattern()
        {
            IApprovalBookingStrategyPattern approvalPattern;

            ApprovalPatternFactory approvalPatternFactory = new ApprovalPatternFactory();

            approvalPattern = ApprovalPatternFactory.ApprovalStrategy();

            return approvalPattern;

        }
    }
}
