using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    internal class TimeTraveler : Alien
    {
        public TimeTraveler(string name, string personalData, string species, string alienPowers, string visitDuration) : base(name, personalData, species, alienPowers, visitDuration)
        {
        }

        public void TimeTravel()
        {
            Console.WriteLine("Time Travelers experience synchronicity in xeno singularity simulations.");
        }

        public new void Communicate(string message)
        {
            Console.WriteLine("Time Traveler says: " + message);
        }
    }
}
