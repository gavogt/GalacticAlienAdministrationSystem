using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class FacilityRegistrationService
    {
        public List<Facility> facilityList = new List<Facility>();
        List<IFacility> iFacilityList = new List<IFacility>();
        public void RegisterFacility(Facility facility)
        {
            facilityList.Add(facility);
            
        }

        public List<Facility> ReturnFacility()
        {
            return facilityList;
        }


        public List<IFacility> ReturnIFacility()
        {
   
            return iFacilityList;
        }
    }
}
