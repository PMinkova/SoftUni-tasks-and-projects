using System;

namespace _04_CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string carClass = "";
            string carType = "";

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
               
                    carType = "Jeep";
                    price = 0.9 * budget;
            }
            else
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = 0.8 * budget;
                }
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
