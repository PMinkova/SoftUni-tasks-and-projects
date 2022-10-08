using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _02_ArrayModifier
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

            while (input != "end")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);

                    SwapNumbers(firstIndex, secondIndex, numbers);
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);

                    Multiply(firstIndex, secondIndex, numbers);
                }
                else if (command == "decrease")
                {
                    DecreaseAllNumbersWithOne(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

        static void SwapNumbers(int firstIndex, int secondIndex, List<int> numbers)
        {
            int firstNumber = numbers[firstIndex];

            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = firstNumber;
        }

        static void Multiply(int firstIndex, int secondIndex, List<int> numbers)
        {
            numbers[firstIndex] *= numbers[secondIndex];
        }

        static void DecreaseAllNumbersWithOne(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }
    }
}
