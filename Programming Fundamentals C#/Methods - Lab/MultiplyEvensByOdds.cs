using System;
using System.Linq;

namespace _10_MultiplyEvensByOdds
{
    class Program
    {
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int rest = number % 10;
                number /= 10;
                if (rest % 2 == 0)
                {
                    sum += rest;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int rest = number % 10;
                number /= 10;
                if (rest % 2 == 1)
                {
                    sum += rest;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
    }
}
