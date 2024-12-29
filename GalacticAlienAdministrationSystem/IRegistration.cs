using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface IRegistration
    {

        Alien RegisterAlien(string name, string personalData, string species, string specialRequirements, string visitDuration);

        AlienGroup RegisterAlienGroup(Alien alien);

    }
}
