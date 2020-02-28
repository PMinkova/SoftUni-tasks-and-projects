using System;

namespace _02_FamilyTrip
{
    class FamilyTrip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsInHotel = int.Parse(Console.ReadLine());
            double oneNightPrice = double.Parse(Console.ReadLine());
            int percentExtraExpenses = int.Parse(Console.ReadLine());
            double moneyForHotel = 0;

            if (nightsInHotel > 7 )
            {
                moneyForHotel = nightsInHotel * oneNightPrice * 0.95;
            }
            else
            {
                moneyForHotel = nightsInHotel * oneNightPrice;
            }

            double extraExpenses = percentExtraExpenses * budget * 0.01;
            double totalMoney = moneyForHotel + extraExpenses;

            if (totalMoney <= budget)
            {

                Console.WriteLine($"Ivanovi will be left with {budget - totalMoney:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalMoney - budget:f2} leva needed.");
            }
        }
    }
}
