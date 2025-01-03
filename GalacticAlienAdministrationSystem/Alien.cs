using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class Alien : ISpecies
    {
        private static int _AlienIDCounter = 0;
        private string _name;
        private string _personalData;
        private string _species;
        private string _alienPowers;
        private string _visitDuration;
        private bool _isClearedForEarth = false;
        private int _ID;

        public Alien(string name, string personalData, string species, string alienPowers, string visitDuration)
        {
            IncrementIDCounter();
            _ID = _AlienIDCounter;
            _name = name;
            _personalData = personalData;
            _species = species;
            _alienPowers = alienPowers;
            _visitDuration = visitDuration;

        }

        public int GetID()
        {
            return _ID;

        }

        public void IncrementIDCounter()
        {
            _AlienIDCounter++;

        }

        public string GetName()
        {
            return _name;

        }

        public bool ClearedForEarth()
        {
            if (_isClearedForEarth == true)
            {
                return _isClearedForEarth;

            }
            else
            {
                return false;

            }
        }

        public static void SearchFacilitiesForEnvironmentType(int facilityIDEntered, Facility facility)
        {

            switch (facility.environmentType)
            {
                case "Oxygen":
                    WriteLine("Facility environment is Oxygenated");
                    break;
                case "Vacuum":
                    WriteLine("Facility environment is Vacuumed");
                    break;
                case "Methane":
                    WriteLine("Facility environment is Methaned");
                    break;
            }
        }

        public void SearchFacilities(Facility facility)
        {
            if (facility.capacity > 0)
            {
                facility.capacity -= 1;
                _isClearedForEarth = true;
                WriteLine("Facility has capacity and cleared for Earth");
            }
            else
            {
                WriteLine("Facility does not have the capacity");
            }

        }

        public string GetSpecies()
        {
            return _species;
        }

        public string GetAlienPowers()
        {
            return _alienPowers;
        }

        public void Communicate(string message)
        {
            WriteLine($"Alien is communicating: {message}");
        }
    }
}
