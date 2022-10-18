using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();
            string input = Console.ReadLine();

            string pattern = @"(=|\/)(?<destinations>[A-Z][A-Za-z]{2,})\1";

            MatchCollection matches = Regex.Matches(input, pattern); ;
            

            foreach (Match match in matches)
            {
                destinations.Add(match.Groups["destinations"].Value);
            }

            int travelPoints = 0;

            foreach (var destination in destinations)
            {
                travelPoints += destination.Length;
            }

            Console.WriteLine($"Destinations: {String.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
