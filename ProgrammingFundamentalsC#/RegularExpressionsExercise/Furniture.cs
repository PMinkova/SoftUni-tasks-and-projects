using System;
using System.Text.RegularExpressions;

namespace _01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">{2}(?<furniture>[A-Za-z]+)<{2}(?<price>\d+.?\d*)!(?<quantity>\d+)";

            var input = Console.ReadLine();
            var text = String.Empty;

            while (input != "Purchase")
            {
                text += input;
                input = Console.ReadLine();
            }

            var regex = new Regex(pattern);

            var furnitures = regex.Matches(text);

            var totalPrice = 0.0;

            Console.WriteLine("Bought furniture:");
            foreach (Match furniture in furnitures)
            {
                var currentFurniture = furniture.Groups["furniture"].Value;
                var currentPrice = double.Parse(furniture.Groups["price"].Value);
                var quantity = int.Parse(furniture.Groups["quantity"].Value);

                totalPrice += currentPrice * quantity;

                Console.WriteLine(currentFurniture);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
