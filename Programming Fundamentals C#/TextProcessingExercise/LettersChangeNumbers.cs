using System;
using System.Diagnostics;

namespace _08_LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            string[] pairs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (var pair in pairs)
            {
                char firstLetter = pair[0];
                char lastLetter = pair[^1];

                string numAsString = pair[1..^1];
                double num = double.Parse(numAsString);


                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    num /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    num *= position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    num -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    num += position;
                }

                sum += num;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
