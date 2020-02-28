using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_TreasureHunt
{
    class TreasureHunt
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
             
            while (input != "Yohoho!")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];

                switch (command)
                {
                    case "Loot":
                        InsertItemsInTheBeginning(commands, loot);
                        break;
                    case "Drop":
                        RemoveAnItemToTheLastPosition(commands, loot);
                        break;
                    case "Steal":
                        RemoveAndPrintTheStolenItems(commands, loot);
                        break;
                }

                input = Console.ReadLine();
            }

            PrintTheAverageTreasureGain(loot);
        }

        static void InsertItemsInTheBeginning(List<string> commands, List<string> loot)
        {
            for (int i = 1; i < commands.Count; i++)
            {
                string currentItem = commands[i];

                if (!loot.Contains(currentItem))
                {
                    loot.Insert(0, currentItem);
                }
            }
        }
        static void RemoveAnItemToTheLastPosition(List<string> commands, List<string> loot)
        {
            int indexToRemoveLast = int.Parse(commands[1]);

            if (indexToRemoveLast >= loot.Count || indexToRemoveLast < 0)
            {
                return;
            }

            string itemToRemoveLast = loot[indexToRemoveLast];

            if (loot.Contains(itemToRemoveLast))
            {
                loot.RemoveAt(indexToRemoveLast);
                loot.Add(itemToRemoveLast);
            }        
        }

        static void RemoveAndPrintTheStolenItems(List<string> commands, List<string> loot)
        {
            int stolenItemsCount = int.Parse(commands[1]);

            List<string> stolenItems = new List<string>();

            if (stolenItemsCount > loot.Count)
            {
                for (int i = 0; i < loot.Count; i++)
                {
                    string lastElement = loot[loot.Count - 1];
                    stolenItems.Add(lastElement);
                    loot.Remove(lastElement);
                    i--;
                }
            }
            else
            {
                for (int i = 0; i < stolenItemsCount; i++)
                {
                    string lastElement = loot[loot.Count - 1];
                    stolenItems.Add(lastElement);
                    loot.Remove(lastElement);
                }
            }

            stolenItems.Reverse();

            Console.WriteLine(String.Join(", ", stolenItems));
        }

        static void PrintTheAverageTreasureGain(List<string> loot)
        {
            int sumOfAllItemsLength = 0;

            if (loot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }
            else
            {
                for (int i = 0; i < loot.Count; i++)
                {
                    int currentItemLength = loot[i].Length;
                    sumOfAllItemsLength += currentItemLength;
                }

                double avgTreasureGain = (double)sumOfAllItemsLength / loot.Count;
                Console.WriteLine($"Average treasure gain: {avgTreasureGain:f2} pirate credits.");
            }
        }
    }
}
