using System;

namespace _06_TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double salary = 0;

            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.75;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 0.9;
                }
                else
                {
                    salary = kilometers * 1.05;
                }
            }
            else if (5000 < kilometers && kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.95;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 1.1;
                }
                else
                {
                    salary = kilometers * 1.25;
                }
            }
            else if (10000 < kilometers && kilometers <= 20000)
            {
                salary = kilometers * 1.45;
            }

            salary *= 0.9;
            salary *= 4;

            Console.WriteLine($"{salary:f2}");
        }
    }
}
