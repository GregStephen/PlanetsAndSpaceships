using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceshipsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune"};
            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1,"Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            foreach(var planet in planetList)
            {
                Console.Write($"{planet} ");
            }
            Console.WriteLine();
            foreach(var rocky in rockyPlanets)
            {
                Console.Write($"{rocky} ");
            }

            var probesAndPlanets = new Dictionary<string, List<string>>();
            probesAndPlanets.Add("Mariner 10", new List<string>()
            {
                "Mercury",
                "Venus"
            });
            probesAndPlanets.Add("MESSENGER", new List<string>()
            {
                "Mercury",
                "Venus",
                "Earth"
            });
            probesAndPlanets.Add("Mariner 2", new List<string>()
            {
                "Venus"
            });
            probesAndPlanets.Add("Mariner 5", new List<string>()
            {
                "Venus"
            });
            probesAndPlanets.Add("Galileo", new List<string>()
            {
                "Venus",
                "Earth",
                "Jupiter"
            });
            probesAndPlanets.Add("Magellan", new List<string>()
            { "Venus" });
            probesAndPlanets.Add("Mariner 4", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mariner 6", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mariner 7", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mariner 9", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Viking 1 Orbiter", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Viking 2 Orbiter", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mars Pathfinder", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mars Global Surveyor", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("2001 Mars Odyssey", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Spirit", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Opportunity", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Mars Reconnaissance Orbiter", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Phoenix", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Dawn", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("MSL Curiosity", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("MAVEN", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("InSight", new List<string>()
            { "Mars" });
            probesAndPlanets.Add("Pioneer 10", new List<string>()
            { "Jupiter" });
            probesAndPlanets.Add("Pioneer 11", new List<string>()
            {
                "Jupiter",
                "Saturn"
            });
            probesAndPlanets.Add("Voyager 1", new List<string>()
            {
                "Jupiter",
                "Saturn"
            });
            probesAndPlanets.Add("Voyager 2", new List<string>()
            {
                "Jupiter",
                "Saturn",
                "Uranus",
                "Neptune"
            });
            probesAndPlanets.Add("Ulysses", new List<string>()
            { "Jupiter" });

            probesAndPlanets.Add("Cassini", new List<string>()
            {
                "Jupiter",
                "Saturn"
            });
            probesAndPlanets.Add("New Horizons", new List<string>()
            { "Jupiter" });
            probesAndPlanets.Add("Juno", new List<string>()
            { "Jupiter" });
            Console.WriteLine();
            foreach(var planet in planetList)
            {
                var probesOnPlanet = new List<string>();
                foreach(var (probe, listOfPlanets) in probesAndPlanets)
                {
                    if(listOfPlanets.Contains(planet))
                    {
                        probesOnPlanet.Add(probe);
                    }
                }
                string joinedProbes = string.Join(", ", probesOnPlanet);
                Console.WriteLine($"{planet}: {joinedProbes}");
            }
        }
    }
}
