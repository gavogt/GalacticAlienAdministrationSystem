using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class VerifyAlienGroupStrategy : IAlienGroupVerify
    {
        public bool VerifyGroup(AlienGroup aliens)
        {
           if(aliens != null)
            {
                Console.WriteLine("Verified in Group Service");
                return true;
            }
           return false;
        }
    }
}
