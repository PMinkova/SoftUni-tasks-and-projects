using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_FeedTheAnimals
{
    class Animal
    {
        public Animal(string area)
        {
            Area = area;
        }

        public int DailyFoodLimit { get; set; }

        public string Area { get; set; }
    }
    class FeedTheAnimals
    {
        static void Main(string[] args)
        {
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            Dictionary<string, int> areasWithHungryAnimals = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Last Info")
            {
                string[] commandArgs = input.Split(":");

                string command = commandArgs[0];
                string animalName = commandArgs[1];
                int dailyFoodLimit = int.Parse(commandArgs[2]);
                int food = int.Parse(commandArgs[2]);
                string area = commandArgs[3];

                switch (command)
                {
                    case "Add":
                        AddAnimalWithDailyFoodLimit(animals, animalName, area, areasWithHungryAnimals, dailyFoodLimit);
                        break;
                    case "Feed":
                        FeedAnimalAndRemoveItIfFed(animals, animalName, food, areasWithHungryAnimals, area);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Animals:");
            PrintAnimals(animals);

            Console.WriteLine("Areas with hungry animals:");
            PrintAreas(areasWithHungryAnimals);
        }

        private static void PrintAreas(Dictionary<string, int> areasWithHungryAnimals)
        {
            foreach (var area in areasWithHungryAnimals.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{area.Key} : {area.Value}");
            }
        }

        private static void PrintAnimals(Dictionary<string, Animal> animals)
        {
            foreach (var animal in animals.OrderByDescending(x => x.Value.DailyFoodLimit).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value.DailyFoodLimit}g");
            }
        }

        private static void FeedAnimalAndRemoveItIfFed(Dictionary<string, Animal> animals, string animalName, int food,
            Dictionary<string, int> areasWithHungryAnimals, string area)
        {
            if (animals.ContainsKey(animalName))
            {
                animals[animalName].DailyFoodLimit -= food;

                if (animals[animalName].DailyFoodLimit <= 0)
                {
                    animals.Remove(animalName);
                    areasWithHungryAnimals[area]--;
                    Console.WriteLine($"{animalName} was successfully fed");
                }
            }
        }

        private static void AddAnimalWithDailyFoodLimit(Dictionary<string, Animal> animals, string animalName, string area,
            Dictionary<string, int> areasWithHungryAnimals, int dailyFoodLimit)
        {
            if (!animals.ContainsKey(animalName))
            {
                animals.Add(animalName, new Animal(area));

                if (!areasWithHungryAnimals.ContainsKey(area))
                {
                    areasWithHungryAnimals.Add(area, 0);
                }

                areasWithHungryAnimals[area]++;
            }

            animals[animalName].DailyFoodLimit += dailyFoodLimit;
        }
    }
}
