using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Administrator
    {
        private string _userType = "admin";

        public string GetUserType()
        {
            return _userType;
        }
    }
}
