using System;
using System.Linq;

namespace _03_RoudningNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                double roundedNumber = Math.Round(currentNumber, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{currentNumber} => {roundedNumber}");
            }
        }
    }
}
