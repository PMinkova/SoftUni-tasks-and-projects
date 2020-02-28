using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_ArrivingInKathmandu
{
    class ArrivingInKathmandu
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(?<name>[!@#$?A-Za-z0-9]+)=(?<length>\d+)<<(?<geoHashCode>.+)$");

            string line = Console.ReadLine();
            
            while (line != "Last note")
            {
                Match match = regex.Match(line);

                if (match.Success)
                {
                    string nameOfMountain = match.Groups["name"].Value;
                    int geohashcodeLength = int.Parse(match.Groups["length"].Value);
                    string geohashcode = match.Groups["geoHashCode"].Value;

                    bool fullMatch = geohashcodeLength == geohashcode.Length;

                    if (fullMatch)
                    {
                        PrintNameOfMountainAndGeohashcode(nameOfMountain, geohashcode);
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                line = Console.ReadLine();
            }
        }

        private static void PrintNameOfMountainAndGeohashcode(string nameOfMountain, string geohashcode)
        {
            char[] nameOfMountainAsArray = nameOfMountain.ToCharArray();
            nameOfMountainAsArray = nameOfMountainAsArray.Where(x => char.IsLetterOrDigit(x) || x == ' ').ToArray();
            nameOfMountain = new string(nameOfMountainAsArray);
            Console.WriteLine($"Coordinates found! {nameOfMountain} -> {geohashcode}");
        }
    }
}
