using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class QuarantineZoneFacility : Facility, IFacility
    {
        public int quarantineZoneCount { get; set; }
        public string environmentalControls { get; set; }

        public new int facilityID = 65;

        public bool autoApproved = true;

        public new string environmentType = "Methane";

        public QuarantineZoneFacility(int capacity) : base(capacity)
        {
            environmentalControls = "TOXIC GAS";
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
