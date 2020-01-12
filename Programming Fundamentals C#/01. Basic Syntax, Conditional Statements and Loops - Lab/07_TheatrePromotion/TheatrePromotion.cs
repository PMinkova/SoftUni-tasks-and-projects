using System;

namespace _07_TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (0 <= age && age <= 18)
            {
                if (typeOfTheDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfTheDay == "Weekday")
                {
                    price = 18;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
            }
            else if (64 < age && age <= 122)
            {
                if (typeOfTheDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfTheDay == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

            if (price > 0)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
