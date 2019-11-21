using System;
using System.Linq;

namespace _03_RoudningNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            // 0.9 1.5 2.4 2.5 3.14
            double[] numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                double roundetNumber = Math.Round(currentNumber, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{currentNumber} => {roundetNumber}");
            }
        }
    }
}
