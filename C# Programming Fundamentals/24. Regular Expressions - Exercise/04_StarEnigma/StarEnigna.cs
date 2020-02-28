using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04_StarEnigma
{
    class StarEnigna
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                string lettersPattern = @"[SsTtAaRr]";

                MatchCollection lettersMatch = Regex.Matches(message, lettersPattern);

                int lettersCount = lettersMatch.Count;

                string decryptedMessage = String.Empty;

                foreach (var letter in message)
                {
                    decryptedMessage += (char)(letter - lettersCount);                  
                }

                string pattern = @"@(?<planet>[A-Za-z]+)[^\@:\->!]*:(?<population>\d+)[^@:\->!]*!(?<attackType>A|D)![^\@:\->!]*->(?<soldierCount>\d+)";
                var matches = Regex.Matches(decryptedMessage, pattern);

                foreach (Match match in matches)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
