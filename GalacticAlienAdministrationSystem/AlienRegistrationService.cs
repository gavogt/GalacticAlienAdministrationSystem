using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class AlienRegistrationService : IRegistration
    {
        public Alien _alien;
        public List<Alien> alienList = new List<Alien>();

        public Alien RegisterAlien(string name, string personalData, string species, string alienPowers, string visitDuration)
        {
            var alien = AlienFactory.CreateAlien(name, personalData, species, alienPowers, visitDuration);

            return alien;
        }

        public List<Alien> AddAlienToList(Alien alien, List<Alien> alienList)
        {
            alienList.Add(alien);
            Clear();
            WriteLine($"Alien's name is {alien.GetName()}, and was added to the list");
            WriteLine($"Alien species is a {alien.GetSpecies()}");
            MenuDisplay.PressAnyKey();
            return alienList;
        }

        public AlienGroup RegisterAlienGroup(Alien alien)
        {
            AlienGroup alienGroup = new AlienGroup(alien);

            return alienGroup;
        }

        public Alien ListAliens(int alienID, List<Alien> alienList)
        {
            if (alienList.Count == 0 || alienList == null)
            {
                WriteLine("Alien list empty or null");
            }

            foreach (Alien alien in alienList)
            {
                if (alien.GetID() == alienID)
                {
                    return alien;
                }
            }

            WriteLine($"No alien found with {alienID}");
            return null;
        }

        public Alien AddAlien()
        {
            Alien alien;

            string consoleName = ConsoleUI.PromptForString("What's the Alien's name: ");
            string consolePersonalData = ConsoleUI.PromptForString("What's the Alien's personal data: ");
            WriteLine("Species can be: 'Time Traveler', 'Alien', 'Reptilian'");
            string consoleSpecies = ConsoleUI.PromptForString("What's the Alien's species: ");
            string alienPowers = ConsoleUI.PromptForString("What's the Alien's special requirements: ");
            string consoleVisitDuration = ConsoleUI.PromptForString("What's the Alien's visit duration: ");

            AlienRegistrationService alienRegistrationService = new AlienRegistrationService();
            alien = alienRegistrationService.RegisterAlien(consoleName, consolePersonalData, consoleSpecies, alienPowers, consoleVisitDuration);

            Clear();

            return alien;
        }

        public AlienGroup AddAlienToGroup()
        {
            AlienGroup alienGroup;

            AlienRegistrationService alienRegistrationService = new AlienRegistrationService();
            alienGroup = alienRegistrationService.RegisterAlienGroup(_alien);

            Clear();
            WriteLine($"Registered AlienGroup #:{alienGroup.GetGroupID()}");
            ReadKey();
            return alienGroup;
        }
    }
}
