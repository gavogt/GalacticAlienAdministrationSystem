using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class AlienGroup
    {
        private int _groupID = 0;
        public Alien _alien;

        public AlienGroup(Alien alien)
        {
            _groupID++;
            _alien = alien;
        }

        public int GetGroupID()
        {
            return _groupID;
        }
    }
}
