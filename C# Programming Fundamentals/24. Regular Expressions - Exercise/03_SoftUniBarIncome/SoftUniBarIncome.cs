using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03_SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var totalIncome = 0d;

            while (input != "end of shift")
            {
                var pattern = @"^%(?<name>[A-Z][a-z]*)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+\.*[0-9]*)\$$";

                var regex = new Regex(pattern);

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var name = match.Groups["name"].Value;
                    var product = match.Groups["product"].Value;
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    var price = double.Parse(match.Groups["price"].Value);

                    var totalPrice = quantity * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
