using System;
using System.Linq;

namespace _01_SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] commandArgs = input.Split(":|:").ToArray();

                string command = commandArgs[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);
                    message = message.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string substring = commandArgs[1];

                    if (message.Contains(substring))
                    {
                        int substringStartIndex = message.IndexOf(substring);
                        message = message.Remove(substringStartIndex, substring.Length);
                        string result = string.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            result += substring[i];
                        }

                        message += result;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
