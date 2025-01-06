using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface IBookingStatus
    {
        void Approve();
        void Deny();
        void Close();
    }
}
