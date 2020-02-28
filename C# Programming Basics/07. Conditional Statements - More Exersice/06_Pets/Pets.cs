using System;

namespace _06_Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodForOneDayKg = double.Parse(Console.ReadLine());
            double catFoodForOneDayKg = double.Parse(Console.ReadLine());
            double turtleFoodForOneDayGrams = double.Parse(Console.ReadLine());

            double foodTotal = days * (dogFoodForOneDayKg + catFoodForOneDayKg + (turtleFoodForOneDayGrams / 1000));
            double diff = Math.Abs(foodLeft - foodTotal);

            if (foodTotal <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
             {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
