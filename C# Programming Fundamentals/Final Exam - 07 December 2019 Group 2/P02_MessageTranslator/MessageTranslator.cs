using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02_MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"!(?<command>[A-Z][a-z]{2,})!:\[(?<currentMessage>[A-Za-z]{8,})\]");

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                Match match = regex.Match(message);

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                string messageToCheck = match.Groups["currentMessage"].Value;

                List<int> numbers = new List<int>();

                for (int j = 0; j < messageToCheck.Length; j++)
                {
                    char currentChar = messageToCheck[j];

                    if (char.IsLetter(currentChar))
                    {
                        numbers.Add(currentChar);
                    }
                }

                Console.Write($"{match.Groups["command"].Value}: ");
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
