using System;
using System.Collections.Generic;

namespace _01_CountCharsInAString
{
    class CountCharsInAString
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                foreach (var letter in currentWord)
                {
                    if (!lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter] = 0;
                    }

                    lettersCount[letter]++;
                }
            }

            foreach (var letter in lettersCount)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
