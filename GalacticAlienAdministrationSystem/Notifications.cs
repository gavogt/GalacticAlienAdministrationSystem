using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class Notifications : INotifications
    {
        public void Notify(Alien alien)
        {
            Console.WriteLine($"Notification: {alien.GetName()} the {alien.GetSpecies()} activity detected.");
        }
    }
}
