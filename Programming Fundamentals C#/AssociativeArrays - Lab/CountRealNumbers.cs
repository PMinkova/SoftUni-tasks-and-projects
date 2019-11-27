using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var sortedNumbers = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (!sortedNumbers.ContainsKey(currentNumber))
                {
                    sortedNumbers[currentNumber] = 1;
                }
                else
                {
                    sortedNumbers[currentNumber] += 1;
                }
            }

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
