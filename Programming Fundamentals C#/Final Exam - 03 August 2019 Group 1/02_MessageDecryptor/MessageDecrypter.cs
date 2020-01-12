using System;
using System.Text.RegularExpressions;

namespace _02_MessageDecryptor
{
    class MessageDecrypter
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^([%$])([A-Z][a-z]{2,})\1:\s\[(?<firsNumber>\d+)\]\|\[(?<secondNumber>\d+)\]\|\[(?<thirdNumber>\d+)\]\|$");

            int numberOfInputts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputts; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string tag = match.Groups[2].ToString();
                    int firsNum = int.Parse(match.Groups["firsNumber"].ToString());
                    int secondNum = int.Parse(match.Groups["secondNumber"].ToString());
                    int thirdNum = int.Parse(match.Groups["thirdNumber"].ToString());

                    Console.WriteLine(tag + ": " + (char)firsNum + (char)secondNum + (char)thirdNum);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }               
            }
        }
    }
}
