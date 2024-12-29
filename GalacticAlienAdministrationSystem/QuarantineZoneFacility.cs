using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class QuarantineZoneFacility : Facility
    {
        public int quarantineZoneCount { get; set; }
        public string environmentalControls { get; set; }

        public int facilityID = 65;

        public bool autoApproved = true;



        public QuarantineZoneFacility(string name, int capacity) : base(name, capacity)
        {
            environmentalControls = "TOXIC GAS";
        }

        public string EnvironmentalControls()
        {
            return environmentalControls;
        }

        public void QuarantineZoneCount()
        {
            quarantineZoneCount++;
        }
    }
}
