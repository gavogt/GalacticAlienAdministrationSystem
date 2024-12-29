using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class VerifyAlienGroupStrategy : IAlienGroupVerify
    {
        public bool VerifyGroup(AlienGroup aliens)
        {
           if(aliens != null)
            {
                WriteLine("Verified in Group Service");
                return true;
            }

            WriteLine("Not Verified in Group Service");
           return false;
        }
    }
}
