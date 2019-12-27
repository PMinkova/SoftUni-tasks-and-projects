using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            using (var reader = new StreamReader("words.txt"))
            {
                string[] words = reader.ReadLine().ToLower().Split();

                foreach (var word in words)
                {
                    wordsCount.Add(word, 0);
                }
            }

            using (var reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!char.IsLetter(line[i]) && line[i] != ' ') 
                        {
                            line = line.Replace(line[i].ToString(), "");
                        }
                    }

                    string[] currentWords = line.ToLower().Split();

                    foreach (var word in currentWords)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (var writer = new StreamWriter("Output.txt"))
            {
                foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                {
                    string word = kvp.Key;
                    int count = kvp.Value;

                    writer.WriteLine($"{word} - {count}");
                }
            }
        }
    }
}
