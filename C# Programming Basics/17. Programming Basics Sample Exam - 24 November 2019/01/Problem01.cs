using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFoodforOneDay = double.Parse(Console.ReadLine());
            double moneySouvenirsforOneDay = double.Parse(Console.ReadLine());
            double moneyHotelForOneDay = double.Parse(Console.ReadLine());

            double totalMoneyForTraveling = 420.0 / 100.0 * 7 * 1.85;
            double totalMoneyForsouvenirs = 3 * moneySouvenirsforOneDay;
            double totalMoneyForFood = 3 * moneyFoodforOneDay;

            double moneyForHotelFirstDay = moneyHotelForOneDay - 0.10 * moneyHotelForOneDay;
            double moneyForHotelSecondDay = moneyHotelForOneDay - 0.15 * moneyHotelForOneDay;
            double moneyForHotelThirdDay = moneyHotelForOneDay - 0.20 * moneyHotelForOneDay;
            double totalMoneyForHotel = moneyForHotelFirstDay + moneyForHotelSecondDay + moneyForHotelThirdDay;

            double totalSum = totalMoneyForTraveling + totalMoneyForFood + totalMoneyForsouvenirs + totalMoneyForHotel;


           
            Console.WriteLine($"Money needed: {totalSum:f2}"); 
        }
    }
}
