using System;

namespace _08_CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double moneyAsaGift = 0;
            double savings = 0;
            int moneyFromToys = 0;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0)
                {
                    moneyAsaGift = moneyAsaGift + 10;
                    savings += moneyAsaGift;
                    savings -= 1;
                }
                else
                {
                    moneyFromToys += toyPrice;
                }

            }
            if (washingMashinePrice > (moneyFromToys + savings))
            {
                Console.WriteLine("No! {0:f2}", washingMashinePrice - moneyFromToys - savings);
            }
            else
            {
                Console.WriteLine("Yes! {0:f2}", moneyFromToys + savings - washingMashinePrice);
            }
        }
    }
}
