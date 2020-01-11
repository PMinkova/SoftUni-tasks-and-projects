using System;

namespace _04_VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePriceKg = double.Parse(Console.ReadLine());
            double fruitsPriceKg = double.Parse(Console.ReadLine());
            int vegetablesQuantity = int.Parse(Console.ReadLine());
            int fruitsQuantity = int.Parse(Console.ReadLine());

            double vegetablesPriceBGN = vegetablePriceKg * vegetablesQuantity;
            double fruitsPriceBGN = fruitsPriceKg * fruitsQuantity;

            double totalPriceEuro = (vegetablesPriceBGN + fruitsPriceBGN) / 1.94;

            Console.WriteLine($"{totalPriceEuro:f2}");
        }
    }
}
