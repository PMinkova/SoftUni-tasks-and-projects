using System;

namespace _03_SummerOutfit
{
    class SummerOutFit
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if (timeOfDay == "Morning")
            {
                if (10 <= degrees && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees >= 25)
                {
                    outfit = "T - Shirt";
                    shoes = "Sandals";
                }
                else if (18 < degrees && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (10 <= degrees && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (18 < degrees && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
