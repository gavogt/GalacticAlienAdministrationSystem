using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface ISpecies
    {
        public string GetName();
        public string GetSpecies();
        public string GetAlienPowers();

        public void Communicate(string message);
    }
}
