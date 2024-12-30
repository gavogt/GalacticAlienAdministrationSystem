using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class ResearchLabFacility : Facility, IFacility
    {
        public string researchLabLocation { get; set; }
        public int conductResearch { get; set; }

        public new int facilityID = 55;

        public bool autoapproved = true;

        public new string environmentType = "Vacuum";

        public ResearchLabFacility(int capacity, string researchLabLocation) : base(capacity)
        {
            this.researchLabLocation = researchLabLocation;

        }

        public override string ToString()
        {
            return base.ToString() + $"Research Lab Location: {researchLabLocation}";
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
