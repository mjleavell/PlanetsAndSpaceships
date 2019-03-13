using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PlanetList = new List<string>() { "Mercury", "Mars" };

            // 1. `Add()` Jupiter and Saturn at the end of the list.
            PlanetList.Add("Jupiter");
            PlanetList.Add("Saturn");

            // 2.Create another `List` that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            // 3.Combine the two lists by using `AddRange()`.
            PlanetList.AddRange(lastTwoPlanets);

            // 4.Use `Insert()` to add Earth, and Venus in the correct order.
            PlanetList.Insert(1, "Earth");
            PlanetList.Insert(1, "Venus");

            // 5.Use `Add()` again to add Pluto to the end of the list.
            PlanetList.Add("Pluto");

            // 6.Now that all the planets are in the list, slice the list using `GetRange()`
            // in order to extract the rocky planets into a new list called `rockyPlanets`.
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = PlanetList.GetRange(4, 5);

            // 7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` 
            // method to eliminate it from the end of `PlanetList`.
            PlanetList.Remove("Pluto");


            // ***********************Iterating over Planets***********************
            // 1.Create another dictionary that will hold the name of a spacecraft that we have launched, 
            // and a list of names of the planets that it has visited.
            // Remember that `List` is a Type just like native types(such as `string`, `int`, & `bool`) 
            // and your custom types(such as `Movie`, `Dog`, and `Food`). They can be passed to anything, like a dictionary, as a Type.
            var MercuryProbes = new List<string>
            {
                "Mariner 10",
                "Messenger"
            };

            var VenusProbes = new List<string>
            {
                "Mariner 2",
                "Venera 4",
                "Mariner 5",
                "Venera 5",
                "Venera 6"
            };

            var EarthProbes = new List<string>
            {
                "Giotto",
                "Galileo",
                "Cassini",
                "Stardust"
            };

            var MarsProbes = new List<string>
            {
                "Mariner 4",
                "Mariner 6",
                "Mariner 7"
            };

            var JupiterProbes = new List<string>
            {
                "Pioneer 10",
                "Pioneer 11",
                "Voyager 1",
                "Voyager 2"
            };

            var SaturnProbes = new List<string>
            {
                "Cassini",
                "Pioneer 11",
                "Voyager 1",
                "Voyager 2"
            };

            var UranusProbes = new List<string> { "Voyager 2" };

            var NeptuneProbes = new List<string> { "Voyager 2" };

            Dictionary<string, List<string>> SpaceProbes = new Dictionary<string, List<string>>();

            SpaceProbes.Add(PlanetList[0], MercuryProbes);
            SpaceProbes.Add(PlanetList[1], VenusProbes);
            SpaceProbes.Add(PlanetList[2], EarthProbes);
            SpaceProbes.Add(PlanetList[3], MarsProbes);
            SpaceProbes.Add(PlanetList[4], JupiterProbes);
            SpaceProbes.Add(PlanetList[5], SaturnProbes);
            SpaceProbes.Add(PlanetList[6], NeptuneProbes);
            SpaceProbes.Add(PlanetList[7], UranusProbes);

            // 2.Iterate over your list of planets from above, and inside that loop,
            // iterate over the dictionary.Write to the console, for each planet,
            // which satellites have visited which planet.
            foreach (var planet in PlanetList)
            {
                var probes = "";
                foreach (var probe in SpaceProbes[planet])
                {
                    probes += $"{probe}\n";
                }
                Console.WriteLine($"{planet}: \n{probes} \n");
            }
            Console.ReadLine();
        }
    }
}
