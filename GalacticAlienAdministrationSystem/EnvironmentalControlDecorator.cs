using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class EnvironmentalControlDecorator : FacilityDecorator
    {
        public EnvironmentalControlDecorator(Facility facility) : base(facility)
        {
        }

        public override string GetDetails()
        {
            return ($"{facility.GetDetails()}, This is a decorator, facility has environmental controls");
        }
    }
}
