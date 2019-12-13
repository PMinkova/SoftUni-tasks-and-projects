using System;

namespace _08._HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50 * nightsCount;
                priceApartment = 65 * nightsCount;
                if (nightsCount > 7 && nightsCount < 14)
                {
                    priceStudio *= 0.95;
                }
                else if (nightsCount > 14)
                {
                    priceStudio *= 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20 * nightsCount;
                priceApartment = 68.70 * nightsCount;
                if (nightsCount > 14)
                {
                    priceStudio *= 0.80;
                }
            }
            else 
            {
                priceStudio = 76 * nightsCount;
                priceApartment = 77 * nightsCount;
            }
            if (nightsCount > 14)
            {
                priceApartment *= 0.90;
            }
            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
