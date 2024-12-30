using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class Alien
    {
        private static int _AlienIDCounter = 0;
        private string _name;
        private string _personalData;
        private string _species;
        private string _specialRequirements;
        private string _visitDuration;
        private bool _isClearedForEarth = false;
        private int _ID;

        public Alien(string name, string personalData, string species, string specialRequirements, string visitDuration)
        {
            IncrementIDCounter();
            _ID = _AlienIDCounter;
            _name = name;
            _personalData = personalData;
            _species = species;
            _specialRequirements = specialRequirements;
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

        public void SearchFacilities(Facility facility)
        {

            facility.capacity -= 1;
            _isClearedForEarth = true;
            WriteLine("Facility has capacity and cleared for Earth");


        }
    }
}
