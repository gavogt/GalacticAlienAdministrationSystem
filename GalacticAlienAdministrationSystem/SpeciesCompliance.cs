using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class SpeciesCompliance : ISpeciesCompliance
    {
        public bool IsSpeciesCompliant(Alien alien)
        {
            var species = alien.GetSpecies();
            Clear();
            if (species == "Time Traveler" || species == "Alien")
            {
                WriteLine($"{species} is compliant with the Galactic Administration System");
                return true;
            }
            else if (species == "Reptilian")
            {
                WriteLine($"{species} is not compliant with the Galactic Administration System");
                return false;
            }

            WriteLine($"{species} is not found and not a valid species");

            return false;
        }
    }
}
