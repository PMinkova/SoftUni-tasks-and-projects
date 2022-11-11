using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantsInfo = Console.ReadLine()
                    .Split("<->")
                    .ToArray();

                string plant = plantsInfo[0];
                int rarity = int.Parse(plantsInfo[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new Plant(rarity));
                }
                else
                {
                    plants[plant].Rarity = rarity;
                }
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] commandArgs = input.Split(new []{':',  '-', ' '}, StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string plant = commandArgs[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (command == "Rate")
                    {
                        int rating = int.Parse(commandArgs[2]);
                        plants[plant].Rating.Add(rating);
                    }
                    else if (command == "Update")
                    {
                        int newRarity = int.Parse(commandArgs[2]);
                        plants[plant].Rarity = newRarity;
                    }
                    else if (command == "Reset")
                    {
                        plants[plant].Rating.Clear();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                double averageRaiting = 0;

                if (plant.Value.Rating.Count > 0)
                {
                    averageRaiting = plant.Value.Rating.Average();
                }

                
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {averageRaiting:F2} ");
            }
        }
    }

    public class Plant
    {
        public Plant(int rarity)
        {
            this.Rarity = rarity;
            this.Rating = new List<int>();
        }
        public int Rarity { get; set; }

        public List<int> Rating { get; set; }
    }
}
