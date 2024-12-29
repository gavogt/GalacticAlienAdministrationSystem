using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class FacilityFactory
    {
        public static Facility CreateFacility(FacilityType facilityType, string name, int capacity, string extraData)
        {
            return facilityType switch
            {
                FacilityType.Embassy => new EmbassyFacility(name, capacity, extraData),
                FacilityType.ResearchLab => new ResearchLabFacility(name, capacity, extraData),
                FacilityType.QuarantineZone => new QuarantineZoneFacility(name, capacity),
                _ => throw new ArgumentException("Not a valid Factory creation")
            };
        }

        public static FacilityType ReturnFacilityType(int facilitytype)
        {
            switch (facilitytype)
            {
                case 1:
                    return FacilityType.Embassy;
                case 2:
                    return FacilityType.ResearchLab;
                case 3:
                    return FacilityType.QuarantineZone;
                default:
                    throw new ArgumentException("Not a valid Facility Type");
            }

            return FacilityType.None;
        }
    }
}
