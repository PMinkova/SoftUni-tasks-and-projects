using System;
using System.Text.RegularExpressions;

namespace _02_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(\S+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1");

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                string encryptedPassword = String.Empty;

                if (match.Success)
                {
                    for (int j = 2; j < 6; j++)
                    {
                        encryptedPassword += match.Groups[j];
                    }

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
