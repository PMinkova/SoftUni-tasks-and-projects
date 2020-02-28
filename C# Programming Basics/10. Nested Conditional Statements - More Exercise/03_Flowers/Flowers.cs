using System;

namespace _03_Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int chrysanthemumCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double totalPrice = 0;
            bool hasAdditionalDiscount = (chrysanthemumCount + rosesCount + tulipsCount) >= 20;

            if (season == "Spring" || season == "Summer")
            {
                totalPrice = chrysanthemumCount * 2 + rosesCount * 4.1 + tulipsCount * 2.5;

                if (holiday == "Y")
                {
                    totalPrice *= 1.15;
                }

                if (tulipsCount > 7 && season == "Spring")
                {
                    totalPrice *= 0.95;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                totalPrice = chrysanthemumCount * 3.75 + rosesCount * 4.5 + tulipsCount * 4.15;

                if (holiday == "Y")
                {
                    totalPrice *= 1.15;
                }

                if (rosesCount >= 10 && season == "Winter")
                {
                    totalPrice *= 0.9;
                }
            }

            if (hasAdditionalDiscount)
            {
                totalPrice *= 0.8;
            }

            totalPrice += 2;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
