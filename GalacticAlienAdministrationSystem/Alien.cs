using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Alien
    {
        private string _name;
        private string _personalData;
        private string _species;
        private string _specialRequirements;
        private string _visitDuration;
        private bool _isClearedForEarth;

        public string GetSpecialRequirements()
        {
            return _specialRequirements;
        }

        public string GetSpecies()
        {
            return _species;
        }

        public Alien(string name, string personalData, string species, string specialRequirements, string visitDuration)
        {
            _name = name;
            _personalData = personalData;
            _species = species;
            _specialRequirements = specialRequirements;
            _visitDuration = visitDuration;

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
    }
}
