using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Linq;

namespace GalacticAlienAdministrationSystem
{
    public class MenuDisplay
    {

        public static int Menu()
        {
            int menuSelection;

            Clear();

            WriteLine("Welcome to the Galactic Alien Administration System!");
            WriteLine("   Please select an option from the menu below:");
            WriteLine("\t1. Add a new alien");
            WriteLine("\t2. Add an alien to group");
            WriteLine("\t3. List all Alien Groups");
            WriteLine("\t4. List all booking");
            WriteLine("\t5. Create a new Facility");
            WriteLine("\t6. Create a new Booking");
            WriteLine("\t7. Search facility by capacity");
            WriteLine("\t8. Search facility by Environment Type");
            WriteLine("\t9. Exit");

            Write("\nEnter your selection: ");
            menuSelection = Convert.ToInt32(ReadLine());

            return menuSelection;

        }

        public static void HandleMenuSelection(int menuSelection, AlienRegistrationService ars, List<Alien> listOfAliens, FacilityManager facilityManager, BookingManager bookingManager, AlienLists al, FacilityRegistrationService frs)
        {

            switch (menuSelection)
            {
                case 1:
                    var alien = ars.AddAlien();
                    ars.AddAlienToList(alien, listOfAliens);
                    break;
                case 2:
                    ars.AddAlienToGroup();
                    break;
                case 3:
                    al.ListAlienGroups();
                    break;
                case 4:
                    facilityManager.ListFacilities(frs.ReturnFacility());
                    break;
                case 5:
                    Facility facilityCreated = MenuFacilityCreate();
                    frs.RegisterFacility(facilityCreated);
                    break;
                case 6:
                    bookingManager.BookingCreateApprovalCheck();
                    break;
                case 7:
                    if (listOfAliens != null)
                    {
                        al.ListAlienGroups();
                    }
                    else
                    {
                        WriteLine("List of aliens is empty");
                    }
                    Write("Enter Alien ID from group: ");
                    int.TryParse(ReadLine(), out int alienGroupID);
                    Alien AlienCaseSeven = ars.ListAliens(alienGroupID, listOfAliens);

                    facilityManager.ListFacilities(frs.ReturnFacility());
                    Write("Enter Facility ID: ");
                    int.TryParse(ReadLine(), out int facilityID);

                    Facility facility = facilityManager.ListFacilitiesSearch(facilityID, frs.ReturnFacility());

                    if (AlienCaseSeven != null && facility != null)
                    {
                        AlienCaseSeven.SearchFacilities(facility);
                    }
                    else
                    {
                        WriteLine("Alien or Facility not found");
                    }

                    ReadKey();

                    break;
                case 8:
                    Facility facilityEnvironmentSearch = new Facility();

                    facilityManager.ListFacilitiesEnvironmentType(frs.ReturnFacility());

                    Write("Enter Facility ID: ");
                    int.TryParse(ReadLine(), out int facilityIDEnvironmentSearch);

                    Alien.SearchFacilitiesForEnvironmentType(facilityIDEnvironmentSearch, facilityEnvironmentSearch);

                    break;
                case 9:
                    Environment.Exit(0);
                    break;

                default:
                    WriteLine("Invalid selection");
                    break;
            }
        }

        public static void RunMenuSelection()
        {
            List<Alien> listOfAliens = new List<Alien>();
            AlienRegistrationService ars = new AlienRegistrationService();
            FacilityManager facilityManager = new FacilityManager();
            BookingManager bookingManager = new BookingManager();
            AlienLists al = new AlienLists(listOfAliens);
            FacilityRegistrationService frs = new FacilityRegistrationService();

            LoadingTimers.LoadingTimer();

            while (true)
            {
                int choice = Menu();

                HandleMenuSelection(choice, ars, listOfAliens, facilityManager, bookingManager, al, frs);
            }
        }


        public static Facility MenuFacilityCreate()
        {

            Facility facilityReturn;

            int facilityCapacity = 0;
            string facilityLocation = null;
            int facilitySelection = 0;

            Write("Enter capacity for facility: ");
            int.TryParse(ReadLine(), out facilityCapacity);
            Write("Provide any extra information such as location: ");
            facilityLocation = ReadLine();

            WriteLine("LIST OF FACILITIES");
            WriteLine("1. Embassy");
            WriteLine("2. Research Lab");
            WriteLine("3. Quarantine Zone");
            WriteLine("Provide Selection for Facility type: ");
            while (facilitySelection < 1 || facilitySelection > 3)
            {
                Write("Please enter a number between 1 and 3: ");
                int.TryParse(ReadLine(), out facilitySelection);
            }

            FacilityType type = FacilityType.None;
            type = FacilityFactory.ReturnFacilityType(facilitySelection);


            facilityReturn = FacilityFactory.CreateFacility(type, facilityCapacity, facilityLocation);
            WriteLine($"Created Facility: {facilityReturn.facilityID} and capacity of {facilityReturn.capacity}");

            return facilityReturn;

        }

        public static void PressAnyKey()
        {
            WriteLine("Press any key to continue");
            ReadKey();

        }
    }
}
