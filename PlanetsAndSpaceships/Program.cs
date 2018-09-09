using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            //order of planets: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> morePlanets = new List<string>() { "Uranus", "Neptune" };

            //AddRange() adds the planets listed in morePlanets to the end of planetList
            planetList.AddRange(morePlanets);

            planetList.Insert(2, "Earth");


            Console.ReadLine();

        }
    }
}
