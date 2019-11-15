using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int teddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double amount = (2.60 * puzzleCount) + (3.0 * talkingDollsCount) + (4.10 * teddyBearsCount) + (8.20 * minionsCount) + (2.0 * trucksCount);
            int toysCount = puzzleCount + talkingDollsCount + teddyBearsCount + minionsCount + trucksCount;
            
            double discount = 0.0;

            if (toysCount >= 50)
            {
                discount = 0.25 * amount;
            }
            double totalPrice = amount - discount;
            double pureProfit = totalPrice - (0.1 * totalPrice);

            double moneyLeft = tripPrice - pureProfit;

            if (pureProfit >= tripPrice )
            {
                Console.WriteLine("Yes! {0:F2} lv left.", Math.Abs(moneyLeft));
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(moneyLeft));
            }
        }
    }
}
