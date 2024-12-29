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

        public BookingManager(Facility facility, IApprovalBookingStrategyPattern approvalStrategy)
        {
            _approvalBookingStrategyPattern = approvalStrategy;
            _facility = facility;
        }

        public BookingManager()
        {
            
        }

        public void AddBookings()
        {
            Console.WriteLine($"Adding booking {_bookings.bookingID} to the system");
            _bookingsList.Add(_bookings);
        }

        public List<Booking> GetBookingList()
        {
            return _bookingsList;
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
            Booking bookings = new Booking(10, 10);
            var approvalPattern = ReturnApprovalPattern();
            BookingManager bookingManager = new BookingManager(bookings, approvalPattern);
            bookingManager.ApproveBooking(facility, bookings);
            Console.WriteLine($"Booking {bookings.bookingID} has status {bookings.bookingStatus} for {facility.name}.");

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
