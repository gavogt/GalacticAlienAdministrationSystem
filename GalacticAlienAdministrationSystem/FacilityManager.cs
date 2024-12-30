using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class FacilityManager
    {

        private List<Booking> _bookingList = new List<Booking>();

        public FacilityManager()
        {

        }

        public void ListFacilitiesEnvironmentType(List<Facility> listOfFacilities)
        {
            if (!listOfFacilities.Any())
            {
                WriteLine("No Facilities to list");
            }

            foreach (IFacility facility in listOfFacilities)
            {
                WriteLine($"FacilityID: {facility.GetID()} and Environment: {facility.GetEnvironmentType()}");

            }

            ReadKey();
        }

        public void ListFacilities(List<Facility> listOfFacilities)
        {
            if (!listOfFacilities.Any())
            {
                WriteLine("No Facilities to list");
            }

            foreach (Facility facility in listOfFacilities)
            {
                WriteLine($"FacilityID: {facility.facilityID}");

            }

            ReadKey();
        }

        public Facility ListFacilitiesSearch(int facilityID, List<Facility> listOfFacilities)
        {
            if (listOfFacilities == null)
            {
                WriteLine("List of facilities is null");
            }

            foreach (Facility facility in listOfFacilities)
            {
                if (facility.facilityID == facilityID)
                {

                    return facility;
                }
            }

            return null;

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
