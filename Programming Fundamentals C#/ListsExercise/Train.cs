using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int passengersToAdd = int.Parse(command[1]);
                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengersToFit = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        bool hasEnoughSpace = maxCapacity - wagons[i] >= passengersToFit;

                        if (hasEnoughSpace)
                        {
                            wagons[i] += passengersToFit;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
