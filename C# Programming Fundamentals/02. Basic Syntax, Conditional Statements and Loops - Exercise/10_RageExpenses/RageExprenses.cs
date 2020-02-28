using System;

namespace _10_RageExpenses
{
    class RageExprenses
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCount = lostGamesCount / 2;
            double mouseCount = lostGamesCount / 3;
            double keyboardCount = lostGamesCount / 6;
            double displayCount = lostGamesCount / 12;

            double totalExpenses = headsetCount * headsetPrice + mousePrice * mouseCount +
                keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");        
        }
    }
}
