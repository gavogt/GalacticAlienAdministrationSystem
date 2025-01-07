using System;
using System.Collections.Generic;
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
            int menuSelection = 0;

            Clear();

            MenuList();
            while (menuSelection < 1 || menuSelection > 12)
            {
                Write("\nEnter your menu selection #1 - #12: ");
                int.TryParse(ReadLine(), out menuSelection);
            }

            return menuSelection;

        }

        public static void MenuList()
        {

            WriteLine("Welcome to the Galactic Alien Administration System!");
            WriteLine("   Please select an option from the menu below:");
            WriteLine("\t 1. Add a new alien");
            WriteLine("\t 2. Add an alien to group");
            WriteLine("\t 3. List all Alien Groups");
            WriteLine("\t 4. List all facilities");
            WriteLine("\t 5. Create a new Facility");
            WriteLine("\t 6. Create or Remove a new Booking");
            WriteLine("\t 7. Search facility by capacity");
            WriteLine("\t 8. Search facility by Environment Type");
            WriteLine("\t 9. Display current occupancy of facilities");
            WriteLine("\t10. Create booking with Notifications and Species Check");
            WriteLine("\t11. Set booking state");
            WriteLine("\t12. Exit");
            WriteLine("-------------------------------------------------");

        }

        public static Booking BookingMenu(BookingManager bookingManager, Booking booking)
        {
            BookingCommandScheduler bookingScheduler = new BookingCommandScheduler();

            int choice;
            Clear();
            WriteLine("**********Booking Menu**********");
            WriteLine("Please select an option from the menu below:");
            WriteLine(" 1. Create a new booking");
            WriteLine(" 2. Remove a booking");
            Write("Enter your selection: ");
            int.TryParse(ReadLine(), out choice);

            switch (choice)
            {
                case 1:

                    booking = bookingManager.CreateAndReturnBooking();

                    ICommand createBookingCommand = new CreateBookingCommand(booking, bookingManager);
                    bookingScheduler.SetBookingCommand(createBookingCommand);
                    bookingScheduler.ExecuteBookingCommand();

                    return booking;
                    break;
                case 2:
                    Write("Please supply the booking ID: ");
                    int.TryParse(ReadLine(), out int bookingID);

                    Booking bookingRemove = bookingManager.RetrieveBooking(bookingID);

                    if (bookingRemove == null)
                    {
                        WriteLine("No booking found with that ID");
                        PressAnyKey();
                        break;
                    }

                    ICommand removeBookingCommand = new RemoveBookingCommand(bookingRemove, bookingManager);
                    bookingScheduler.SetBookingCommand(removeBookingCommand);
                    bookingScheduler.ExecuteBookingCommand();
                    return bookingRemove;
                    break;
                default:
                    WriteLine("Invalid selection");
                    break;
            }

            return booking;
        }

        public static void HandleMenuSelection(int menuSelection, AlienRegistrationService ars, List<Alien> listOfAliens, FacilityManager facilityManager, BookingManager bookingManager, AlienLists al, FacilityRegistrationService frs, Booking booking)
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
                    booking = BookingMenu(bookingManager, booking);
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
                    facilityManager.DisplayCurrentOccupancy(frs.ReturnFacility());
                    ReadKey();
                    break;
                case 10:
                    // facade pattern
                    var facadeAlien = ars.AddAlien();
                    ars.AddAlienToList(facadeAlien, listOfAliens);

                    BookingFacadeScheduler bookingFacadeScheduler = new BookingFacadeScheduler();
                    Notifications notifications = new Notifications();
                    SpeciesCompliance speciesCompliance = new SpeciesCompliance();

                    TaskFacadeManager taskFacadeManager = new TaskFacadeManager(speciesCompliance, bookingFacadeScheduler, notifications);
                    taskFacadeManager.ExecuteTask(facadeAlien);
                    ReadKey();
                    break;
                case 11:
                    // state pattern
                    Write("Enter Admin ID: ");
                    int.TryParse(ReadLine(), out int adminID);
                    Administrator admin = new Administrator(adminID);

                    if (admin.Authenticate(adminID))
                    {
                        WriteLine("1. Approve booking");
                        WriteLine("2. Close booking");
                        WriteLine("3. Deny booking");
                        Write("Enter your selection: ");
                        int.TryParse(ReadLine(), out int choice);

                        switch (choice)
                        {
                            case 1:
                                BookingApprovalState bookingApprovalState = new BookingApprovalState();
                                booking.SetBookingState(bookingApprovalState);
                                booking.ApproveBookingState();
                                break;
                            case 2:
                                BookingClosedState bookingClosedState = new BookingClosedState();
                                booking.SetBookingState(bookingClosedState);
                                booking.CloseBookingState();
                                break;
                            case 3:
                                BookingDeniedState bookingDeniedState = new BookingDeniedState();
                                booking.SetBookingState(bookingDeniedState);
                                booking.DenyBookingState();
                                break;
                        }
                    }
                    else { WriteLine("Invalid Admin ID"); }

                    ReadKey();
                    break;
                case 12:
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
            Booking booking = new Booking();

            LoadingTimers.LoadingTimer();

            while (true)
            {
                int choice = Menu();

                HandleMenuSelection(choice, ars, listOfAliens, facilityManager, bookingManager, al, frs, booking);
            }
        }

        public static Facility MenuFacilityCreate()
        {

            Facility facilityReturn;

            int facilityCapacity = 0;
            string facilityLocation = null;
            int facilitySelection = 0;
            int facilityOccupancy = 0;


            Write("Enter capacity for facility: ");
            int.TryParse(ReadLine(), out facilityCapacity);
            Write("Provide any extra information such as location: ");
            facilityLocation = ReadLine();

            FacilityManager.ListOfFacilities();

            WriteLine("Provide Selection for Facility type: ");
            while (facilitySelection < 1 || facilitySelection > 3)
            {
                Write("Please enter a number between 1 and 3: ");
                int.TryParse(ReadLine(), out facilitySelection);
            }

            // Singleton
            var config = GlobalConfig.Instance;

            Write("Provide current occupancy of facility: ");
            facilityOccupancy = Convert.ToInt32(ReadLine());

            while (facilityOccupancy > facilityCapacity || facilityOccupancy > config.maxVisitors || facilityOccupancy < 0)
            {
                WriteLine("Provide a number less than capacity and less than 100");
                facilityOccupancy = Convert.ToInt32(ReadLine());
            }

            foreach (var prohibitedItems in config.prohibitedItems)
            {
                WriteLine($"PROHIBITED ITEM: {prohibitedItems}");
            }

            FacilityType type = FacilityType.None;
            type = FacilityFactory.ReturnFacilityType(facilitySelection);


            facilityReturn = FacilityFactory.CreateFacility(type, facilityCapacity, facilityLocation, facilityOccupancy);
            WriteLine($"Created Facility ID: {facilityReturn.facilityID} with a capacity of {facilityReturn.capacity}");
            ReadKey();

            // Decorator
            EnvironmentalControlDecorator environmentalControlDecorator = new EnvironmentalControlDecorator(facilityReturn);

            WriteLine($"Facility decorator: {environmentalControlDecorator.GetDetails()}");


            ReadKey();


            return facilityReturn;

        }

        public static void PressAnyKey()
        {
            WriteLine("Press any key to continue...");
            ReadKey();

        }
    }
}
