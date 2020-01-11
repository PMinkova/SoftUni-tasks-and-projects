using System;

namespace _01_MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transportPrice = 0;
            double totalPrice = 0;

            if (1 <= people && people <= 4)
            {
                transportPrice = 0.75 * budget;
            }
            else if (5 <= people && people <= 9)
            {
                transportPrice = 0.6 * budget;
            }
            else if (10 <= people && people <= 24)
            {
                transportPrice = 0.5 * budget;
            }
            else if (25 <= people && people <= 49)
            {
                transportPrice = 0.4 * budget;
            }
            else if (people >= 50)
            {
                transportPrice = 0.25 * budget;
            }

            if (ticketType == "VIP")
            {
                totalPrice = people * 499.99 + transportPrice;
            }
            else if (ticketType == "Normal")
            {
                totalPrice = people * 249.99 + transportPrice;
            }

            double diff = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
