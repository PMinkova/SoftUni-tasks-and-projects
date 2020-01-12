using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumAdjacentEqualNumbers
{
    class ListManipulationBasic
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "Add":
                        int numberToInsert = int.Parse(commandParts[1]);
                        numbers.Add(numberToInsert);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandParts[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "Insert":
                        numberToInsert = int.Parse(commandParts[1]);
                        index = int.Parse(commandParts[2]);
                        numbers.Insert(index, numberToInsert);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
