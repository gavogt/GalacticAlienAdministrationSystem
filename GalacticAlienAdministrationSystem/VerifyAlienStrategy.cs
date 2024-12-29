using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class VerifyAlienStrategy : IAlienVerify
    {
        public bool Verify(Alien alien)
        {
            if (alien.ClearedForEarth() == true)
            {

                Console.WriteLine("Verified in Alien Service");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
