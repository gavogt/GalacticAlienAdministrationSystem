using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GalacticAlienAdministrationSystem
{
    public class ConsoleUI
    {

        public static string PromptForString(string message)
        {

            string consoleInput;

            WriteLine(message);

            consoleInput = ReadLine();

            if (consoleInput != null)
            {
                return consoleInput;
            }

            return "Error. Please try again.";

        }
    }
}
