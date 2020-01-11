using System;

namespace _05_Vacantion
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string placeType = "";
            double totalPrice = 0;

            if (budget <= 1000)
            {
                placeType = "Camp";
                if (season == "Summer")
                {
                    totalPrice = 0.65 * budget;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    totalPrice = 0.45 * budget;
                    location = "Morocco";
                }
            }
            else if (budget > 3000)
            {
                placeType = "Hotel";
                totalPrice = 0.9 * budget;

                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }
            else
            {
                placeType = "Hut";

                if (season == "Summer")
                {
                    totalPrice = 0.8 * budget;
                    location = "Alaska";
                }
                else
                {
                    totalPrice = 0.6 * budget;
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {placeType} - {totalPrice:f2}");
        }
    }
}
