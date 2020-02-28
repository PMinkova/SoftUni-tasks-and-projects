using System;

namespace P01NikuldensCharity

{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if (command == "Replace")
                {
                    string currentChar = commandArgs[1];
                    string newChar = commandArgs[2];
                    message = ReplaceChar(message, currentChar, newChar);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    message = CutSubstring(startIndex, endIndex, message);

                }
                else if (command == "Make")
                {
                    string caseType = commandArgs[1];
                    message = ChangeCaseType(caseType, message);
                    Console.WriteLine(message);
                }
                else if (command == "Check")
                {
                    string stringToCheck = commandArgs[1];
                    CheckMessageForContainingString(message, stringToCheck);
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    SumCharsOfSubstring(message, startIndex, endIndex);

                }

                input = Console.ReadLine();
            }
        }

        private static void SumCharsOfSubstring(string message, int startIndex, int endIndex)
        {
            bool isIndexValid = 0 <= startIndex && startIndex <= endIndex && startIndex <= endIndex &&
                                endIndex < message.Length;
            if (isIndexValid)
            {
                int LengthOfSubstring = endIndex - startIndex + 1;
                string substring = message.Substring(startIndex, LengthOfSubstring);
                char[] substringAsArray = substring.ToCharArray();
                int sum = 0;

                for (int i = 0; i < substringAsArray.Length; i++)
                {
                    sum += substringAsArray[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }

        private static void CheckMessageForContainingString(string message, string stringToCheck)
        {
            if (message.Contains(stringToCheck))
            {
                Console.WriteLine($"Message contains {stringToCheck}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {stringToCheck}");
            }
        }

        private static string ChangeCaseType(string caseType, string message)
        {
            if (caseType == "Upper")
            {
                message = message.ToUpper();
            }
            else if (caseType == "Lower")
            {
                message = message.ToLower();
            }

            return message;
        }

        private static string CutSubstring(int startIndex, int endIndex, string message)
        {
            bool isIndexValid = 0 <= startIndex && startIndex <= endIndex && startIndex <= endIndex &&
                                endIndex < message.Length;
            if (isIndexValid)
            {
                int count = endIndex - startIndex + 1;
                message = message.Remove(startIndex, count);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }

            return message;
        }

        private static string ReplaceChar(string message, string currentChar, string newChar)
        {
            message = message.Replace(currentChar, newChar);
            Console.WriteLine(message);
            return message;
        }
    }
}
