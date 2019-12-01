using System;
using System.Linq;

namespace _02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintVowelsCount(word);
        }

        static void PrintVowelsCount(string word)
        {
            int vowelsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                string vowel = "AaEeIiOoUu";

                if (vowel.Contains(currentLetter))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
