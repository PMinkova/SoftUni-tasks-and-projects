using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _03_MoovigTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);

                if (command == "Shoot" && IsIndexValid(index, numbers))
                {
                    int power = int.Parse(commandArgs[2]);

                    numbers[index] -= power;

                    if (numbers[index] <= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(commandArgs[2]);

                    if (IsIndexValid(index, numbers))
                    {
                        numbers.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(commandArgs[2]);
                    int previousIndex = index - radius;
                    int nextIndex = index + radius;

                    if (IsIndexValid(index, numbers) && 
                        IsIndexValid(previousIndex, numbers) && 
                        IsIndexValid(nextIndex, numbers))
                    {
                        numbers.RemoveRange(previousIndex, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", numbers));
        }

        public static bool IsIndexValid(int index, List<int> numbers)
        {
            if (0 <= index && index < numbers.Count)
            {
                return true;
            }

            return false;
        }
    }
}
