using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace _01_TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var encryptedMessage = Console.ReadLine();
            string decryptedMessage = String.Empty;

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] commandArgs = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(commandArgs[1]);

                    string substring = encryptedMessage.Substring(0, numberOfLetters);

                    decryptedMessage = encryptedMessage
                        .Remove(0, numberOfLetters);

                    encryptedMessage += substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    decryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    decryptedMessage = encryptedMessage.Replace(substring, replacement);
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }
    }
}
