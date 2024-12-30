using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class AlienLists
    {
        private List<Alien> _groupList;

        public AlienLists(List<Alien> groupList)
        {
            _groupList = groupList;
        }

        public void ListAlienGroups()
        {
            Clear();
            WriteLine("\t=== List of Aliens ===");
            foreach (var group in _groupList)
            {
                WriteLine($"\tName of the Alien: {group.GetName()} \n\tID of the Alien: {group.GetID()}");

            }
            ReadKey();

        }
    }
}