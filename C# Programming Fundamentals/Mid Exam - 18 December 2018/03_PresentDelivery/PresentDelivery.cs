using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_PresentDelivery
{
    class PresentDelivery
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int startingIndex = 0;

            while (input != "Merry Xmas!")
            {
                string[] commandParts = input.Split();

                int jump = int.Parse(commandParts[1]);

                for (int i = 0; i < jump; i++)
                {
                    startingIndex++;

                    if (startingIndex == houses.Count)
                    {
                        startingIndex = 0;
                    }
                }

                if (houses[startingIndex] == 0)
                {
                    Console.WriteLine($"House {startingIndex} will have a Merry Christmas.");
                }
                else
                {
                    houses[startingIndex] -= 2;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {startingIndex}.");

            bool isMissionSuccessful = true;
            int housesCount = 0;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] != 0)
                {
                    isMissionSuccessful = false;
                    housesCount++;
                }
            }

            if (isMissionSuccessful)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {housesCount} houses.");
            }
        }
    }
}
