using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            double averageNumber = numbers.Average();

            foreach (var number in numbers)
            {
                if (number > averageNumber)
                {
                    result.Add(number);
                }
            }

            result.Sort();
            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if(result.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(result[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
