using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class FacilityManager
    {
        private List<Facility> _facilityList = new List<Facility>();
        private Facility _facility;
        private List<Booking> _bookingList = new List<Booking>();

        public FacilityManager()
        {

        }

        public void ListFacilities()
        {
            if (!_facilityList.Any())
            {
                WriteLine("No Facilities to list");
            }

            foreach (Facility facility in _facilityList)
            {
                WriteLine($"FacilityID: {facility.facilityID}");

            }

            ReadKey();
        }

        public Booking AddBooking()
        {
            DisplayFacilites();
            WriteLine("Enter Facility ID: ");
            if (!int.TryParse(ReadLine(), out int bookingFacilityID))
            {
                WriteLine("Error. Not a valid facility ID");
            }

            WriteLine("Enter User ID: ");
            if (!int.TryParse(ReadLine(), out int userIDUsedForBooking))
            {
                WriteLine("Error. Not a valid user ID");
            }


            Booking booking = new Booking(bookingFacilityID, userIDUsedForBooking);

            return booking;

        }

        public void DisplayFacilites()
        {
            foreach (FacilityType facility in Enum.GetValues(typeof(FacilityType)))
            {
                int facilityValue = (int)facility;
                WriteLine($"{facility} is {facilityValue}");

            }
        }
    }

    public enum FacilityType
    {
        None = 0,
        Embassy = 25,
        ResearchLab = 55,
        QuarantineZone = 65

    }
}
