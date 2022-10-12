using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            int movesCount = 0;
            bool hasWon = false;

            while (input != "end")
            {
                string[] indexes = input.Split();

                movesCount++;

                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);

                bool firstIndexIsOutSideOfArray = IsOutSideOfArray(elements, firstIndex);
                bool secondIndexIsOutSideOfArray = IsOutSideOfArray(elements, secondIndex);
                bool isInvalidInput
                    = firstIndexIsOutSideOfArray || secondIndexIsOutSideOfArray ||
                                    firstIndex == secondIndex;

                if (isInvalidInput)
                {
                    int currentMiddleIndex = elements.Count / 2;
                    elements.Insert(currentMiddleIndex, $"-{movesCount}a");
                    elements.Insert(currentMiddleIndex + 1, $"-{movesCount}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    string elementToRemove = elements[firstIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {elementToRemove}!");
                    elements.Remove(elementToRemove);
                    elements.Remove(elementToRemove);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (IsWinning(elements))
                {
                    hasWon = true;
                    break;
                }

                input = Console.ReadLine();
            }


            if (hasWon)
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }

        }

        private static bool IsWinning(List<string> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                string currentElement = elements[i];

                for (int j = i; j < elements.Count; j++)
                {
                    if (currentElement == elements[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsOutSideOfArray(List<string> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                return true;
            }

            return false;
        }
    }
}
