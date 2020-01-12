using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_TheFinalQuest
{
    class TheFinalQuest
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "Delete":
                        int indexToRemove = int.Parse(commandParts[1]) + 1;
                        DeleteIndex(words, indexToRemove);
                        break;
                    case "Swap":
                        string firstWord = commandParts[1];
                        string secondWord = commandParts[2];
                        SwapWords(words, firstWord, secondWord);
                        break;
                    case "Put":
                        string word = commandParts[1];
                        int index = int.Parse(commandParts[2]);
                        AddAWordAtThePreviousIndex(words, word, index);
                        break;
                    case "Sort":
                        words.Sort();
                        words.Reverse();
                        break;
                    case "Replace":
                        firstWord = commandParts[1];
                        secondWord = commandParts[2];
                        ReplaceSecondWordWithFirstWord(words, firstWord, secondWord);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", words));
        }

        static void DeleteIndex(List<string> words, int index)
        {
            bool isIndexValid = 0 <= index && index < words.Count;

            if (isIndexValid)
            {
                words.RemoveAt(index);
            }
        }

        static void SwapWords(List<string> words, string firstWord, string SecondWord)
        {
            bool areWordsExist = words.Contains(firstWord) && words.Contains(SecondWord);

            if (areWordsExist)
            {
                int firstWordIndex = words.IndexOf(firstWord);
                int secondWordIndex = words.IndexOf(SecondWord);

                words.Remove(SecondWord);
                words.Insert(firstWordIndex, SecondWord);
                words.Remove(firstWord);
                words.Insert(secondWordIndex, firstWord);             
            }
        }

        static void AddAWordAtThePreviousIndex(List<string> words, string word, int index)
        {
            int indexToInsertAt = index - 1;
            bool isIndexValid = 0 <= indexToInsertAt && indexToInsertAt <= words.Count;

            if (isIndexValid)
            {
                words.Insert(indexToInsertAt, word);
            }
        }

        static void ReplaceSecondWordWithFirstWord(List<string> words, string firstWord, string secondWord)
        {
            if (words.Contains(secondWord))
            {
                int indexOfTheSecondWord = words.IndexOf(secondWord);
                words.Remove(secondWord);
                words.Insert(indexOfTheSecondWord, firstWord);
            }
        }
    }
}
