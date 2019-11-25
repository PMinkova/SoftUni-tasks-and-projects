using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_ListOperations
{
    class ListOfOperations
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
                List<string> commandParts = input.Split().ToList();

                string command = commandParts[0];

                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        InsertANumber(numbers, commandParts);
                        break;
                    case "Remove":
                        RemoveANumber(numbers, commandParts);
                        break;
                    case "Shift":
                        ShiftANumber(numbers, commandParts);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void InsertANumber(List<int> numbers, List<string> commandParts)
        {
            int numberToInsert = int.Parse(commandParts[1]);
            int indexToInsertAt = int.Parse(commandParts[2]);

            if (indexToInsertAt >= 0 && indexToInsertAt <= numbers.Count)
            {
                numbers.Insert(indexToInsertAt, numberToInsert);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void RemoveANumber(List<int> numbers, List<string> commandParts)
        {
            int indexToRemove = int.Parse(commandParts[1]);

            if (indexToRemove >= 0 && indexToRemove < numbers.Count)
            {
                numbers.RemoveAt(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void ShiftANumber(List<int> numbers, List<string> commandParts)
        {
            string direction = commandParts[1];
            int count = int.Parse(commandParts[2]);

            switch (direction)
            {
                case "left":
                    ShiftLeft(numbers, count);
                    break;
                case "right":
                    ShiftRight(numbers, count);
                    break;
            }
        }

        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Remove(firstNumber);
                numbers.Add(firstNumber);
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.Remove(lastNumber);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
