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
        private readonly List<Alien> _alienList = new List<Alien>();

        public AlienGroup(Alien alien)
        {
            _groupID++;
            _alien = alien;
        }

        public void AddAlien()
        {
            _alienList.Add(_alien);
        }

        public List<Alien> GetAlienList()
        {
            return _alienList;
        }

        public int GetGroupID()
        {
            return _groupID;
        }
    }
}
