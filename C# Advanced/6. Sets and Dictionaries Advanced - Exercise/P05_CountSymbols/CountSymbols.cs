using System;
using System.Collections.Generic;

namespace P05_CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (!symbols.ContainsKey(currentSymbol))
                {
                    symbols.Add(currentSymbol, 0);
                }

                symbols[currentSymbol]++;
            }

            foreach (var element in symbols)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }
    }
}
