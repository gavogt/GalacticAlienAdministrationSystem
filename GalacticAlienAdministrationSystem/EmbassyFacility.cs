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

        public new int facilityID = 25;

        public bool autoApproval = false;

        public new string environmentType = "Oxygen";


        public EmbassyFacility(int capacity, string country, int currentOccupancy) : base(capacity, currentOccupancy)
        {

            this.country = country;
        }

        public override string ToString()
        {
            return base.ToString() + $"In the embassies, the aliens are able to communicate with the outside world we're from {country}";

        }

        public new bool IsApproved()
        {
            return autoApproval;
        }

        public new int GetID()
        {
            return facilityID;
        }

        public new string GetEnvironmentType()
        {
            return environmentType;
        }
    }
}

