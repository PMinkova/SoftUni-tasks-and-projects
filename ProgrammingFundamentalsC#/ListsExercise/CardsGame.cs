using System;
using System.Linq;
using System.Collections.Generic;

namespace _06_CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                }
                else if (secondDeck[0] > firstDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                }

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);
            }

            if (firstDeck.Count > secondDeck.Count)
            {
                int sum = firstDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
