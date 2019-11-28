using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] productInfo = input.Split();

                string currentProduct = productInfo[0];
                double priceForOneProduct = double.Parse(productInfo[1]);
                double quantity = double.Parse(productInfo[2]);

                if (!products.ContainsKey(currentProduct))
                {
                    products.Add(currentProduct, new List<double> {priceForOneProduct, quantity});
                }
                else
                {
                    products[currentProduct][0] = priceForOneProduct;
                    products[currentProduct][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                var totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
