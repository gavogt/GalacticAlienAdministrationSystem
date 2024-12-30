using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public interface IBookingManager
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notify(Booking booking);
    }
}
