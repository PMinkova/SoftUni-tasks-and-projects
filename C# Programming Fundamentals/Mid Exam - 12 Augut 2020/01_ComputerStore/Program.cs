using System;

namespace _01_ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;

            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += price;
                }

                input = Console.ReadLine();
            }

            if (priceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double taxes = 0.2 * priceWithoutTaxes;
                double priceWithTaxes = priceWithoutTaxes + taxes;

                if (input == "special")
                {
                    priceWithTaxes *= 0.9;
                }

                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:F2}$");
            }
        }
    }
}
