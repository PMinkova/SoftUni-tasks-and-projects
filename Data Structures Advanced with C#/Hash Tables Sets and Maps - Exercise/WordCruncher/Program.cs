using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCruncher
{
    class Program
    {
        static void Main()
        {
            var wordParts = Console.ReadLine().Split(", ").ToArray();
            var word = Console.ReadLine();

            for (int i = 0; i < wordParts.Length; i++)
            {
                if (word.StartsWith(wordParts[i]))
                {
                    Console.Write(wordParts[i] + " ");

                    var length = wordParts[i].Length;
                    word = word.Remove(0, length);
                }

            }

        }
    }
}
