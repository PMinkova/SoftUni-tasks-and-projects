using System;

namespace _05_Orders
{
    class Program
    {
        static void PrintTotalPrice(string product, int number)
        {
            double totalPrice = 0;

            switch (product)
            {
                case "coffee":
                    totalPrice = number * 1.5;
                    break;
                case "water":
                    totalPrice = number * 1;
                    break;
                case "coke":
                    totalPrice = number * 1.4;
                    break;
                case "snacks":
                    totalPrice = number * 2;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
        
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintTotalPrice(productName, quantity);

        }
    }
}
