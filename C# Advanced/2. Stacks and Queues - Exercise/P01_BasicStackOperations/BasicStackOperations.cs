using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] splitedInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberOfElementsToPush = splitedInput[0];
            int numberofElementsToPop = splitedInput[1];
            int numberToLookForInTheStack = splitedInput[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                numbers.Push(integers[i]);
            }

            for (int i = 0; i < numberofElementsToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(numberToLookForInTheStack))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
