using System;
using System.Collections.Generic;

namespace P06_Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string[] splitedInput = Console.ReadLine().Split(" -> ");
                string[] clothes = splitedInput[1].Split(",");

                string color = splitedInput[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string current = clothes[j];

                    if (!wardrobe[color].ContainsKey(current))
                    {
                        wardrobe[color].Add(current, 0);
                    }

                    wardrobe[color][current]++;
                }
            }

            string[] itemToLookFor = Console.ReadLine().Split();
            string colorOfTheItem = itemToLookFor[0];
            string itemToFind = itemToLookFor[1];

            foreach (var colorKvp in wardrobe)
            {
                bool isRightColor = false;

                string color = colorKvp.Key;

                Console.WriteLine($"{color} clothes:");

                if (color == colorOfTheItem)
                {
                    isRightColor = true;
                }

                var clothes = colorKvp.Value;

                foreach (var item in clothes)
                {
                    if (isRightColor && item.Key == itemToFind)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
