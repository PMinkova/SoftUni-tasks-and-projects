using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _01_Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            string[] wordsWithDefinitions = input.Split(" | ");

            for (int i = 0; i < wordsWithDefinitions.Length; i++)
            {
                string[] tokens = wordsWithDefinitions[i].Split(": ");
                string word = tokens[0];
                string definition = tokens[1];

                AddWordsAndDefinitions(words, word, definition);
            }

            while (true)
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                } 

                if (input == "List")
                {
                    PrintWords(words);
                    break;
                }

                string[] newWords = input.Split(" | ");

                PrintWordsAndDefinitions(newWords, words);
            }
        }

        private static void AddWordsAndDefinitions(Dictionary<string, List<string>> words, string word, string definition)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, new List<string>());
            }

            words[word].Add(definition);
        }

        private static void PrintWords(Dictionary<string, List<string>> words)
        {
            foreach (var word in words.OrderBy(x => x.Key))
            {
                Console.Write(word.Key + " ");
            }

            Console.WriteLine();
            return;
        }

        private static void PrintWordsAndDefinitions(string[] newWords, Dictionary<string, List<string>> words)
        {
            foreach (var word in newWords)
            {
                if (words.ContainsKey(word))
                {
                    Console.WriteLine(word);
                    words[word].OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine($"-{x}"));
                }
            }
        }
    }
}
