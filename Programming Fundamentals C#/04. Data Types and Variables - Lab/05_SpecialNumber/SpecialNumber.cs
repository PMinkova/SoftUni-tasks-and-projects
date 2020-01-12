using System;

namespace _05_SpecialNumber
{
    class SpecialNumber
    {
        static void Main(string[] args)
        {
            int totalNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalNumber; i++)
            {
                int number = i;
                int sum = 0;

                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
