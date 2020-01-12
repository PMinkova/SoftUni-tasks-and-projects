using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02_Race
{
    class Race
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            Dictionary<string, int> racersNamesAndPoints = new Dictionary<string, int>();

            foreach (var name in names)
            {
                racersNamesAndPoints.Add(name, 0);
            }

            string patternForRacersName = "[A-Za-z]";
            string patternForDistance = "[0-9]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                Regex regex = new Regex(patternForRacersName);
                var racerName = regex.Matches(input);
                string currentName = String.Empty;

                foreach (Match letter in racerName)
                {
                    currentName += letter;
                }

                regex = new Regex(patternForDistance);
                var digits = regex.Matches(input);
                int currentDistance = 0;

                foreach (Match digit in digits)
                {
                    currentDistance += int.Parse(digit.ToString());
                }

                if (racersNamesAndPoints.ContainsKey(currentName))
                {
                    racersNamesAndPoints[currentName] += currentDistance;
                }

                input = Console.ReadLine();
            }

            int counter = 1;

            foreach (var kvp in racersNamesAndPoints.OrderByDescending(x => x.Value).Take(3))
            {
                string result = "";

                switch (counter)
                {
                    case 1: result = "1st place:"; break;
                    case 2: result = "2nd place:"; break;
                    case 3: result = "3rd place:"; break;
                }

                string name = kvp.Key;

                Console.WriteLine(result + " " + name);
                counter++;
            }
        }
    }
}
