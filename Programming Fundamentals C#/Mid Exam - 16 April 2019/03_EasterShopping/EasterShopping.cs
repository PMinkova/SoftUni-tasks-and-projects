using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_EasterShopping
{
    class EasterShopping
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandParts = Console.ReadLine().Split();
                string command = commandParts[0];

                if (command == "Include")
                {
                    string shop = commandParts[1];
                    shops.Add(shop);
                }
                else if (command == "Visit" && commandParts[1] == "first")
                {
                    int numbersToRemoveCount = int.Parse(commandParts[2]);

                    if (numbersToRemoveCount <= shops.Count)
                    {
                        shops.RemoveRange(0, numbersToRemoveCount);
                    }
                }
                else if (command == "Visit" && commandParts[1] == "last")
                {
                    int numbersToRemoveCount = int.Parse(commandParts[2]);

                    if (numbersToRemoveCount <= shops.Count)
                    {
                        shops.Reverse();
                        shops.RemoveRange(0, numbersToRemoveCount);
                        shops.Reverse();
                    }
                }
                else if (command == "Prefer")
                {
                    int shopIndexOne = int.Parse(commandParts[1]);
                    int shopIndexTwo = int.Parse(commandParts[2]);

                    if (0 <= shopIndexOne && shopIndexOne < shops.Count &&
                        0 <= shopIndexTwo && shopIndexTwo < shops.Count)
                    {
                        string firstShop = shops[shopIndexOne];
                        string seconsShop = shops[shopIndexTwo];
                        shops[shopIndexTwo] = firstShop;
                        shops[shopIndexOne] = seconsShop;
                    }
                }
                else if (command == "Place")
                {
                    string shop = commandParts[1];
                    int index = int.Parse(commandParts[2]);

                    if (0 <= index && index < shops.Count)
                    {
                        shops.Insert(index + 1, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(String.Join(" ", shops));
        }
    }
}
