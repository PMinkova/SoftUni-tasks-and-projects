using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] splitedInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int enqueueCount = splitedInput[0];
            int dequeueCount = splitedInput[1];
            int numberToLookForInTheQueue = splitedInput[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();

            EnqueueElements(enqueueCount, numbers, integers);
            DequeueElements(dequeueCount, numbers);
            LookForAnElementInTheQueue(numbers, numberToLookForInTheQueue);
        }

        private static void LookForAnElementInTheQueue(Queue<int> numbers, int numberToLookForInTheQueue)
        {
            if (numbers.Contains(numberToLookForInTheQueue))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Any() ? numbers.Min() : 0);
            }
        }

        private static void DequeueElements(int dequeueCount, Queue<int> numbers)
        {
            for (int i = 0; i < dequeueCount; i++)
            {
                numbers.Dequeue();
            }
        }

        private static void EnqueueElements(int enqueueCount, Queue<int> numbers, int[] integers)
        {
            for (int i = 0; i < enqueueCount; i++)
            {
                numbers.Enqueue(integers[i]);
            }
        }
    }
}
