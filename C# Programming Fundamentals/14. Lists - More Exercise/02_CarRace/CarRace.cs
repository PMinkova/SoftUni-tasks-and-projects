using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class CarRace
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double timeLeft = 0;
            double timeRight = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                timeLeft += numbers[i];
                timeRight += numbers[numbers.Count - i - 1];

                if (numbers[i] == 0)
                {
                    timeLeft *= 0.8;
                }

                if (numbers[numbers.Count - i - 1] == 0)
                {
                    timeRight *= 0.8;
                }
            }

            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRight}");
            }
        }
    }
}
