using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface IFacadeScheduling
    {
        public bool IsAvailable(Booking booking);
        public void CreateBookingSchedule();

    }
}
