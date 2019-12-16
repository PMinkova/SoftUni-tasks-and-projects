using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> counts = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }

                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
