using System;
using System.Linq;

namespace _02_HelloFrance
{
    class HelloFrance
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split("|");

            double budget = double.Parse(Console.ReadLine());
            double startingBudget = budget;
            double[] newPrices = new double[data.Length];
            double moneyForTickets = 150;
            double totalProfit = 0;

            for (int i = 0; i < data.Length; i++)
            {
                string[] current = data[i].Split("->");
                string type = current[0];
                double price = double.Parse(current[1]);
               
                if (type == "Clothes")
                {
                    if (price <= 50.00 && budget - price >= 0)
                    {
                        budget -= price;
                        double newPrice = 1.4 * price;
                        totalProfit += newPrice - price;
                        newPrices[i] = newPrice;
                    }
                }
                else if (type == "Shoes")
                {
                    if (price <= 35.00 && budget - price >= 0)
                    {
                        budget -= price;
                        double newPrice = 1.4 * price;
                        totalProfit += newPrice - price;
                        newPrices[i] = newPrice;
                    }
                }
                else if (type == "Accessories")
                {
                    if (price <= 20.50 && budget - price >= 0)
                    {
                        budget -= price;
                        double newPrice = 1.4 * price;
                        totalProfit += newPrice - price;
                        newPrices[i] = newPrice; ;
                    }
                }
            }

            bool haveEnoughMoney = startingBudget + totalProfit - moneyForTickets >= 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (newPrices[i] != 0)
                {
                    Console.Write($"{newPrices[i]:f2}" + " ");
                }
            }
            Console.WriteLine();


            Console.WriteLine($"Profit: {totalProfit:f2}");

            if (haveEnoughMoney)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            } 
        }
    }
}
