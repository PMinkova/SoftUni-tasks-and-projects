using System;
using Microsoft.VisualBasic;

namespace _01_StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] commandArgs = commandLine.Split();
                string command = commandArgs[0];


                if (command == "Translate")
                {
                    string charToreplace = commandArgs[1];
                    string replacement = commandArgs[2];

                    input = input.Replace(charToreplace, replacement);

                    Console.WriteLine(input);
                }
                else if (command == "Includes")
                {
                    string stringToCheck = commandArgs[1];
                    Console.WriteLine(input.Contains(stringToCheck));
                }
                else if (command == "Start")
                {
                    string stringToCheck = commandArgs[1];
                    Console.WriteLine(input.StartsWith(stringToCheck));
                }
                else if (command == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    string charToFindIndexOf = commandArgs[1];
                    int lastIndex = input.LastIndexOf(charToFindIndexOf);

                    Console.WriteLine(lastIndex);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    input = input.Remove(startIndex, count);

                    Console.WriteLine(input);
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}
