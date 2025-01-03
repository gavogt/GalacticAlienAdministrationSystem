using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Reptilian : Alien
    {
        public Reptilian(string name, string personalData, string species, string alienPowers, string visitDuration) : base(name, personalData, species, alienPowers, visitDuration)
        {

        }

        public void ShapeShift()
        {
            Console.WriteLine("Reptilians can shape shift into any form they desire.");
        }

        public new void Communicate(string message)
        {
            Console.WriteLine("Reptilian says: " + message);
        }


    }
}
