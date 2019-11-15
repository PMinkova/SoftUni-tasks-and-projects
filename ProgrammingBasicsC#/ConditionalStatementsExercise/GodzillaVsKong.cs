using System;

namespace _06_GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());

            double decor = 0.1 * budget;
            double outfitTotal = extras * outfit;

            if (extras > 150)
            {
                outfitTotal *= 0.9;
            }

            double expenses = decor + outfitTotal;

            if (expenses <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - expenses):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - expenses):f2} leva more.");
            }
        }
    }
}
