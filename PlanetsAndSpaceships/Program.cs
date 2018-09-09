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

            //Insert() returns a new string in which a specified string is inserted at a specified index position in the current string instance.
            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            //GetRange() creates a shallow copy of a range of elements frm the planetList List. The parameters tell the method the index value of where to begin and how many to include.
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");


            Console.ReadLine();

        }
    }
}
