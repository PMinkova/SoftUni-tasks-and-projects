using System;
using System.Collections.Generic;

namespace _02_OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < line.Length; i++)
            {
                string currentWord = line[i].ToLower();

                if (!words.ContainsKey(currentWord))
                {
                    words[currentWord] = 0;
                }

                words[currentWord]++;
            }

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
