using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace P03Nikuldensmeals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
            Dictionary<string, int> unlikedMeals = new Dictionary<string, int>();
            int unlikedMealsCount = 0;

            string line = Console.ReadLine();
            
            while (line != "Stop")
            {
                string[] commandArgs = line.Split("-");

                string command = commandArgs[0];
                string guestName = commandArgs[1];
                string meal = commandArgs[2];

                if (command == "Like")
                {
                    if (!likedMeals.ContainsKey(guestName))
                    {
                        likedMeals.Add(guestName, new List<string>());
                    }

                    if (!likedMeals[guestName].Contains(meal))
                    {
                        likedMeals[guestName].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!likedMeals.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else if (!likedMeals[guestName].Contains(meal))
                    {
                        Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} doesn't like the {meal}.");
                        likedMeals[guestName].Remove(meal);
                        //unlikedMeals.Add(guestName, 0);
                        //unlikedMeals[guestName]++;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var guest in likedMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.Write($"{guest.Key}: ");
                Console.WriteLine(String.Join(", ", guest.Value));
            }

            //foreach (var guest in unlikedMeals)
            //{
            //    Console.WriteLine($"{guest.Key}:");
            //    Console.WriteLine($"Unliked meals: {guest.Value}");
            //}
            Console.WriteLine($"Unliked meals: {unlikedMealsCount}");
        }
    }
}
