using System;

namespace _07_VendingMachine
{
    class VendingMashine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0; 

            while (input != "Start")
            {
                double coins = double.Parse(input);
                bool isValid = coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2;

                if (isValid)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string productName = Console.ReadLine();

            bool isNotValid = productName != "Nuts" && productName != "Water" &&
                productName != "Crisps" && productName != "Soda" && productName != "Coke";

            while (productName != "End")
            {
                if (isNotValid)
                {
                    Console.WriteLine("Invalid product");
                }
                else if (productName == "Nuts" && sum >= 2)
                {
                    sum -= 2;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else if (productName == "Water" && sum >= 0.7)
                {
                    sum -= 0.7;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else if (productName == "Crisps" && sum >= 1.5)
                {
                    sum -= 1.5;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else if (productName == "Soda" && sum >= 0.8)
                {
                    sum -= 0.8;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else if (productName == "Coke" && sum >= 1)
                {
                    sum -= 1;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                productName = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
