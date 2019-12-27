using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < linesCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var number in numbers.Where(n => n.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}
