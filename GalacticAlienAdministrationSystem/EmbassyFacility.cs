using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class EmbassyFacility : Facility, IFacility
    {
        public string country { get; }

        public int visitorCount { get; set; }

        public int facilityID = 25;

        public bool autoApproval = false;

        public EmbassyFacility(string name, int capacity, string country) : base(name, capacity)
        {
           
            this.country = country;
        }

        public void RegisterVisitor()
        {
            visitorCount++;
        }

        public override string ToString()
        {
            return base.ToString() + $"In the embassies, the aliens are able to communicate with the outside world we're from {country}";

        }

        public bool IsApproved()
        {
            return autoApproval;
        }


    }
}
 
