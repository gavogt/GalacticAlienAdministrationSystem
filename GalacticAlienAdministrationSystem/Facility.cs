using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Facility : IFacility
    {
        public int facilityID = 10;
        public int capacity;
        public string environmentType = "standard facility";
        public bool isApproved { get; set; }
        
        public int currentOccupancy = 0;

        public Facility(int capacity, int currentOccupancy)
        {
            if (capacity > 0 && capacity >= currentOccupancy)
            {
                this.currentOccupancy = currentOccupancy;
                this.capacity = capacity;
            }
            else
            {
                Console.WriteLine("Not enough capacity for the current occupancy");
                Console.ReadKey();
            }
        }

        public Facility()
        {

        }

        public int SetCurrentOccupancy(int currentOccupancy)
        {
            this.currentOccupancy = currentOccupancy;
            return currentOccupancy;
        }

        public int ReturnCurrentOccupancy()
        {
            return (capacity - currentOccupancy);
        }

        public override string ToString()
        {
            return $"\t Facility ID: {facilityID}, \n\t Facility Capacity: {capacity}";
        }

        public bool IsApproved()
        {
            return isApproved;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public int GetID()
        {
            return facilityID;
        }

        public string GetEnvironmentType()
        {
            return environmentType;
        }

        public int GetOccupancy()
        {
            return currentOccupancy;
        }
    }
}
