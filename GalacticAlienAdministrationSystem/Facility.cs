using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public abstract class Facility : IFacility
    {
        public int facilityID = 10; 
        public string name;
        public int capacity;
        public bool isApproved { get; set; }

        public Facility(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }


        public override string ToString()
        {
            return $"\t Facility ID: {facilityID}, \n\t Facility Name: {name} Facility Capacity: \n\t{capacity}";
        }

        public bool IsApproved()
        {
            return isApproved;
        }
    }
}
