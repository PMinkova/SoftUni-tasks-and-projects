using System;
using System.Text.RegularExpressions;

namespace _02_SongEncryption
{
    class SongEncription
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(?<artist>[A-Z][a-z\s\']+):(?<song>[A-Z\s]+)$");

            string line = Console.ReadLine();

            while (line != "end")
            {
                Match match = regex.Match(line);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int key = match.Groups["artist"].Length;

                    char[] lineAsCharArray = line.ToCharArray();

                    for (int i = 0; i < lineAsCharArray.Length; i++)
                    {
                        char currentChar = lineAsCharArray[i];

                        bool isUpperLetter = 'A' <= currentChar && currentChar <= 'Z';
                        bool isLowerLetter = 'a' <= currentChar && currentChar <= 'z';

                        if (isLowerLetter && currentChar + key > 'z')
                        {
                            int diff = (currentChar + key) - 'z';
                            currentChar = (char)(diff + 'a' - 1);
                        }
                        else if (isUpperLetter && currentChar + key > 'Z')
                        {
                            int diff = (currentChar + key) - 'Z';
                            currentChar = (char)(diff + 'A' - 1);
                        }
                        else if (isUpperLetter || isLowerLetter)
                        {
                            currentChar = (char)(currentChar + key);
                        }

                        lineAsCharArray[i] = currentChar;
                    }

                    line = new string(lineAsCharArray);
                    line = line.Replace(":", "@");

                    Console.WriteLine($"Successful encryption: {line}");
                }

                line = Console.ReadLine();
            }
        }
    }
}
