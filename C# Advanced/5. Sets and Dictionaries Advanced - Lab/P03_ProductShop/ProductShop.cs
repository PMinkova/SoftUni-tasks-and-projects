using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace P03_ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] splitedInput = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = splitedInput[0];
                string product = splitedInput[1];
                double price = double.Parse(splitedInput[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop][product] = price;
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}-> ");

                foreach (var product in shop.Value)
                {
                    var productName = product.Key;
                    var price = product.Value;
                    Console.WriteLine($"Product: {productName}, Price: {price}");
                }

            }
        }
    }
}
