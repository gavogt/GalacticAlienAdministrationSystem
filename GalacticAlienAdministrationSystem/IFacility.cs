using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface IFacility
    {
        public string ToString();

        public bool IsApproved();
    }
}
