using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Administrator
    {
        private string _name;
        private string _description;
        private string _password;
        private string _email;
        private string _userType = "admin";

        public string GetUserType()
        {
            return _userType;
        }
    }
}
