using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public abstract class FacilityDecorator : IDecorator
    {
        public Facility facility = new Facility();

        protected FacilityDecorator(Facility facility)
        {
            this.facility = facility;
        }

        public abstract string GetDetails();
    }
}
