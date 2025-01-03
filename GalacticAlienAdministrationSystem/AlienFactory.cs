using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAlienAdministrationSystem
{
    public class AlienFactory
    {

        public static Alien CreateAlien(string name, string personalData, string species, string alienPowers, string visitDuration)
        {
            return species switch
            {
                "Time Traveler" => new Alien(name, personalData, species, alienPowers, visitDuration),
                "Reptilian" => new Alien(name, personalData, species, alienPowers, visitDuration),
                "Alien" => new Alien(name, personalData, species, alienPowers, visitDuration),
                _ => throw new ArgumentException("Not a valid Factory creation")
            };
        }


    }
}

