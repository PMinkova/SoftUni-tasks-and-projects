using System;

namespace _05_FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double amount = 0;
            
           

            if (season == "Spring")
            {
                amount = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                amount = 4200;
            }
            else if (season == "Winter")
            {
                amount = 2600;  
            }

            if (fishers <= 6)
            {
                amount *= 0.9;
            }
            else if (fishers >= 12)
            {
                amount *= 0.75;
            }
            else
            {
                amount *= 0.85;
            }

            if ((season == "Spring" || season == "Summer" || season == "Winter") && fishers % 2 == 0)
            {
                amount *= 0.95;    //тук може да бъде и    if  (fishers % 2 == 0 && season != "Autumn")
            }

            if (budget >= amount )
            {
                double moneyLeft = budget - amount;
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else 
            {
                double moneyMoreNeeded = amount - budget;
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyMoreNeeded);
            }
        }
    }
}
