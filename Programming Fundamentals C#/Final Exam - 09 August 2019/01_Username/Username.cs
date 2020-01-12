using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _01_Username
{
    class Username
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                switch (command)
                {
                    case "Case":
                        string caseType = commandArgs[1];
                        username = ChangeCaseTypeAndPrint(caseType, username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);
                        ReverseSubstringAndPrintIt(startIndex, endIndex, username);
                        break;
                    case "Cut":
                        string substring = commandArgs[1];
                        username = CutAndPrintSubstringIfExist(username, substring);
                        break;
                    case "Replace":
                        string charAsString = commandArgs[1];
                        username = username.Replace(charAsString, "*");
                        Console.WriteLine(username);
                        break;
                    case "Check":
                        charAsString = commandArgs[1];
                        CheckIfPasswordIsValid(username, charAsString);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void CheckIfPasswordIsValid(string username, string charAsString)
        {
            if (username.Contains(charAsString))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine($"Your username must contain {charAsString}.");
            }
        }

        private static string CutAndPrintSubstringIfExist(string username, string substring)
        {
            if (username.Contains(substring))
            {
                username = username.Replace(substring, "");
                Console.WriteLine(username);
            }
            else
            {
                Console.WriteLine($"The word {username} doesn't contain {substring}.");
            }

            return username;
        }

        private static void ReverseSubstringAndPrintIt(int startIndex, int endIndex, string username)
        {
            bool isIndexValid = CheckIfIndexIsValid(startIndex, endIndex, username);

            if (isIndexValid)
            {
                int length = endIndex - startIndex + 1;
                string substring = username.Substring(startIndex, length);
                char[] substringAsAChar = substring.Reverse().ToArray();
                substring = new string(substringAsAChar);
                Console.WriteLine(substring);
            }
        }

        private static bool CheckIfIndexIsValid(int startIndex, int endIndex, string username)
        {
            if (0 <= startIndex && startIndex <= endIndex && 0 <= endIndex && endIndex < username.Length)
            {
                return true;
            }

            return false;
        }

        private static string ChangeCaseTypeAndPrint(string caseType, string username)
        {
            if (caseType == "lower")
            {
                username = username.ToLower();
            }
            else if (caseType == "upper")
            {
                username = username.ToUpper();
            }

            Console.WriteLine(username);
            return username;
        }
    }
}
