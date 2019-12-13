using System;

namespace _06_Jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string vacationType = "";
            double budgetPercent = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    budget *= 0.3;
                }
                else
                {
                    vacationType = "Hotel";
                    budget *= 0.7;
                }
            }
            else if (budget > 1000)
            {
                    destination = "Europe";
                    vacationType = "Hotel";
                    budget *= 0.9;
            }
            else
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    budget *= 0.4;
                }
                else
                {
                    vacationType = "Hotel";
                    budget *= 0.8;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {budget:F2}");
        }
    }
}
