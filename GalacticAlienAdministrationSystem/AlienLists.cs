using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class AlienLists : IEnumerable<Alien>
    {
        private List<Alien> _groupList;

        public IEnumerator<Alien> GetEnumerator() => _groupList.GetEnumerator();

        public AlienLists(List<Alien> groupList)
        {
            _groupList = groupList;
        }

        public void ListAlienGroups()
        {
            Console.Clear();
            Console.WriteLine("=== List of Aliens ===");
            foreach (var group in _groupList)
            {
                Console.WriteLine($"{group.GetName()}");
            }
            Console.ReadKey();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}