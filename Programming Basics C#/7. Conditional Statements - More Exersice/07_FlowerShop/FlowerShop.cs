using System;

namespace _07_FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double totalSum = magnoliasCount * 3.25 + hyacinthCount * 4 + rosesCount * 3.5 + cactusCount * 8;
            totalSum *= 0.95;
            double diff = Math.Abs(totalSum - presentPrice);

            if (totalSum >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
            else
            {
                Console.WriteLine($" She will have to borrow {Math.Ceiling(diff)} leva.");
            }
        }
    }
}
