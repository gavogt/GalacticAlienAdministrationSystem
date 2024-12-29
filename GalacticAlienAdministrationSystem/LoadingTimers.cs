using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public static class LoadingTimers
    {
        public static void LoadingTimer()
        {
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
