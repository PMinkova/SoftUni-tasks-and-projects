using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            bool isChanged = false;

            while (input != "end")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "Add":
                        int numberToInsert = int.Parse(commandParts[1]);
                        numbers.Add(numberToInsert);
                        isChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandParts[1]);
                        numbers.RemoveAt(index);
                        isChanged = true;
                        break;
                    case "Insert":
                        numberToInsert = int.Parse(commandParts[1]);
                        index = int.Parse(commandParts[2]);
                        numbers.Insert(index, numberToInsert);
                        isChanged = true;
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(commandParts[1]);
                        CheckContainingANumber(numbers, numberToCheck);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = commandParts[1];
                        int number = int.Parse(commandParts[2]);
                        FilterNumbers(numbers, condition, number);
                        break;
                }

                input = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static void CheckContainingANumber(List<int> numbers, int numberToCheck)
        {
            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                } 
            }
        }

        static void PrintOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        static void FilterNumbers(List<int> numbers, string condition, int number)
        {
            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
