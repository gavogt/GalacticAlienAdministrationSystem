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

            // Alien Ascii Art
            Console.WriteLine("          .-\"\"\"\"\"-.");
            Console.WriteLine("         /         \\");
            Console.WriteLine("        /  .-\"\"\"-.  \\");
            Console.WriteLine("       :  /       \\  :");
            Console.WriteLine("       | |  o   o  | |");
            Console.WriteLine("       : |    ‾    | :");
            Console.WriteLine("        \\ \\___^___/ /");
            Console.WriteLine("         \\_________/");
            Console.WriteLine("          .\"       \".");
            Console.WriteLine("         /           \\");
            Console.WriteLine("        /             \\");
            Console.WriteLine("       /|             |\\");
            Console.WriteLine("      ^ |             | ^");
            Console.WriteLine();

            Console.WriteLine("Welcome to the .NET 8.0 Alien Console App!");

            Thread.Sleep(2000);
            Console.Clear();

        }
    }
}
