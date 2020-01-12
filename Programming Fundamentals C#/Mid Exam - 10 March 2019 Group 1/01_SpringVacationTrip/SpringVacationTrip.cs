using System;

namespace _01_SpringVacationTrip
{
    class SpringVacationTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double priceForOneKilometer = double.Parse(Console.ReadLine());
            double foodPriceForOnePersonForOneDay = double.Parse(Console.ReadLine());
            double roomPriceForOnePersonForOneDay = double.Parse(Console.ReadLine());

            double totalMoneyForHotel = days * peopleCount * roomPriceForOnePersonForOneDay;

            if (peopleCount > 10)
            {
                totalMoneyForHotel *= 0.75;
            }

            double totalMoneyForFood = days * peopleCount * foodPriceForOnePersonForOneDay;

            double totalExpences = totalMoneyForHotel + totalMoneyForFood;
            bool hasEnoughMoney = true;

            for (int i = 1; i <= days; i++)
            {
                double kilometersPerDay = double.Parse(Console.ReadLine());
                double moneyForFuelPerday = kilometersPerDay * priceForOneKilometer;

                totalExpences += moneyForFuelPerday;

                if (totalExpences > budget)
                {
                    hasEnoughMoney = false;
                    break;
                }

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpences *= 1.4;
                }

                if (i % 7 == 0)
                {
                    double moneyRecieve = totalExpences / peopleCount;
                    totalExpences -= moneyRecieve;
                }

                if (totalExpences > budget)
                {
                    hasEnoughMoney = false;
                    break;
                }
            }
            double diff = Math.Abs(budget - totalExpences);

            if (hasEnoughMoney)
            {
                Console.WriteLine($"You have reached the destination. You have {diff:f2}$ budget left.");
            }
            else
            { 
                Console.WriteLine($"Not enough money to continue the trip. You need {diff:f2}$ more.");
            }
        }
    }
}
