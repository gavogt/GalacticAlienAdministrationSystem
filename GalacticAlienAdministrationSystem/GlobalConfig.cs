using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class GlobalConfig
    {
        /// <summary>
        /// Lazy singleton pattern
        /// </summary>
        
        // deferred initialization
        private static readonly Lazy<GlobalConfig> instance = new(() => new GlobalConfig());

        private GlobalConfig()
        {
           
            maxVisitors = 100;
            visitingHours = "9:00 AM - 5:00 PM";
            prohibitedItems = new List<string>() { "Alien Space Lasers", "Telepathic Amplifiers", "Quantum Entaglement Communicators" };
            idRequired = true;
            
        }

        // instance.value initalizes global config instance
        public static GlobalConfig Instance => instance.Value;

        public int maxVisitors { get; set; }
        public string visitingHours { get; set; }
        public List<string> prohibitedItems { get; set; }
        public bool idRequired { get; set; }
    }
}
