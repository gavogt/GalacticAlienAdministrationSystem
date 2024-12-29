using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class VerifyAlienStrategy : IAlienVerify
    {
        public bool Verify(Alien alien)
        {
            if (alien.ClearedForEarth())
            {

                WriteLine("Verified in Alien Service");
                return true;
            }
            else
            {
                WriteLine("Not Verified in Alien Service");
                return false;
            }
        }
    }
}
