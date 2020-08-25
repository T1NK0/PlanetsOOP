using System;
using System.Collections.Generic;

namespace PlaneterneOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet("Merkur", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet earth = new Planet("Jorden", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
            Planet neptune = new Planet("Neptun", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            List<Planet> planets = new List<Planet>(); //Creates our list, we can add our planets to.
            planets.Add(mercury); //adds "mercury" to the list using the lists name "planets".add to say we want to add the item to the end of the list.
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            Console.WriteLine("Uden Venus:");
            //Writes our list of planets.
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            planets.Insert(1, venus); //Inserts venus into index 1, so it's between mercury and earth as requested.
            Console.WriteLine("Med Venus:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            planets.Remove(pluto); //Removes pluto from the list.
            Console.WriteLine("Uden Pluto:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            planets.Insert(8, pluto); //Inserts the planet "pluto" back into the list at index 8.
            Console.WriteLine("Med Pluto tilføjet igen");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            Console.Write("Antal elementer i listen: ");
            Console.WriteLine(planets.Count); //Writes the amount of items in the list "planets" using the count function.

            Console.WriteLine();

            List<Planet> planetsMeanTemp = new List<Planet>(); //Creates the new list for the planets with meantemp below 0.
            foreach (var planet in planets) //Checks the old planet list.
            {
                if (planet.MeanTemperature < 0) //If the planets meantemperature is below 0.
                {
                    planetsMeanTemp.Add(planet); //Add it to the new list "planetsMeanTemp"
                }
            }

            Console.WriteLine("Liste med planeter med Mean Temperature under 0:");
            foreach (var planet in planetsMeanTemp) //Foreach planet in the new list "planetsMeanTemp".
            {
                Console.WriteLine(planet.Name); //Udskriver navnet for alle de planeter der er tilføjet til den nye liste "planetsMeanTemp".
            }

            Console.WriteLine();

            List<Planet> planetsDiameter = new List<Planet>(); //Creates new list which contains planets with a certain diameter
            foreach (var planet in planets) //Foreach planet in planets do the code below.
            {
                if (planet.Diameter >= 10000 && planet.Diameter <= 50000 ) //If the planet diameter is bigger than 10000 but smaller than 50000.
                {
                    planetsDiameter.Add(planet); //Add to the new list "planetsDiameter".
                }
            }

            Console.WriteLine("Planeter med en diameter som er mere end 10000 og mindre end 50000");
            foreach (var planet in planetsDiameter) //Checks on all planets in the new list "planetsDiameter"
            {
                Console.WriteLine(planet.Name); //Writes out the planet names of the planets in the new list.
            }

        }
    }
}
