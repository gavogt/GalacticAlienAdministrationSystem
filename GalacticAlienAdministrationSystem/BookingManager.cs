using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class BookingManager : IBookingManager
    {
        private List<Booking> _bookingsList = new List<Booking>();
        private Booking _bookings;
        private IApprovalBookingStrategyPattern _approvalBookingStrategyPattern;
        private static List<IObserver> _observers = new List<IObserver>();

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

            GalacticTelepathyMessenger galacticTelepathy = new GalacticTelepathyMessenger();
            CosmicEmail cosmicEmail = new CosmicEmail();

            BookingManager bookingManager = new BookingManager();

            bookingManager.AddObserver(galacticTelepathy);
            bookingManager.AddObserver(cosmicEmail);

            Booking bookings = new Booking(10, 10, DateTime.Now, DateTime.Now.AddHours(1));
            Booking bookings2 = new Booking(20, 20, DateTime.Now, DateTime.Now.AddDays(1));

            UpdateBookingStatus(bookings, "Pending");
            UpdateBookingStatus(bookings2, "Approved");

            MenuDisplay.PressAnyKey();

        }

        public IApprovalBookingStrategyPattern ReturnApprovalPattern()
        {
            IApprovalBookingStrategyPattern approvalPattern;

            ApprovalPatternFactory approvalPatternFactory = new ApprovalPatternFactory();

            approvalPattern = ApprovalPatternFactory.ApprovalStrategy();

            return approvalPattern;

        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);

        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);

        }

        public void Notify(Booking booking)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(booking);

            }
        }

        public void UpdateBookingStatus(Booking booking, string status)
        {
            booking.bookingStatus = status;
            Notify(booking);

        }
    }
}
