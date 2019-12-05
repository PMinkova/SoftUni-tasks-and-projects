using System;
using System.Text.RegularExpressions;

namespace _02_Deciphering
{
    class Deciphering
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();
            string[] substrings = Console.ReadLine().Split();

            Regex regex = new Regex(@"^[{}|#d-z]+$");

            Match match = regex.Match(encryptedString);

            if (match.Success)
            {
                char[] encryptedStringAsArray = encryptedString.ToCharArray();
                string decodedString = string.Empty;

                foreach (var ch in encryptedStringAsArray)
                {
                    int currentCharAsNumber = ch - 3;
                    decodedString += (char)currentCharAsNumber;
                }

                string firstSubstring = substrings[0];
                string secondSybstring = substrings[1];

                if (decodedString.Contains(firstSubstring))
                {
                    decodedString = decodedString.Replace(firstSubstring, secondSybstring);
                }

                Console.WriteLine(decodedString);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
