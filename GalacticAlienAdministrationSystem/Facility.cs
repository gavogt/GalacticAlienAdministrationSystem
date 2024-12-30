﻿using System;
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
        public string environmentType { get; }
        public bool isApproved { get; set; }

        public Facility(int capacity)
        {
            this.capacity = capacity;
        }

        protected Facility()
        {
            Console.WriteLine("Empty constructor");
        }

        public override string ToString()
        {
            return $"\t Facility ID: {facilityID}, \n\t Facility Capacity: {capacity}";
        }

        public bool IsApproved()
        {
            return isApproved;
        }

        public int ReturnCapacity()
        {
            return capacity;
        }
    }
}
