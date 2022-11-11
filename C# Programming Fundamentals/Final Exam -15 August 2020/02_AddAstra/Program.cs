using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_AddAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(\||#)(?<item>[A-Za-z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            var regex = new Regex(pattern);

            var matches = regex.Matches(inputLine);

            var totalCalories = 0;
            var productsInfo = new List<string>();


            foreach (Match match in matches)
            {
                var itemName = match.Groups["item"].Value;
                var expirationdate = match.Groups["expirationDate"].Value;
                var calories = int.Parse(match.Groups["calories"].Value);

                totalCalories += calories;

                string currentProductInfo = $"Item: {itemName}, Best before: {expirationdate}, Nutrition: {calories}";
                productsInfo.Add(currentProductInfo);
            }

            var dailyCaloriesIntake = 2000;
            var totalDays = totalCalories / dailyCaloriesIntake;

            Console.WriteLine($"You have food to last you for: {totalDays} days!");

            foreach (var product in productsInfo)
            {
                Console.WriteLine(product);
            }
        }
    }
}
