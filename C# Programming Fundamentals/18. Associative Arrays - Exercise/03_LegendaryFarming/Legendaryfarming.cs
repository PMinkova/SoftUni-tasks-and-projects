using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    class Legendaryfarming
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            var junk = new Dictionary<string, int>();

            string input = Console.ReadLine();
            bool hasWinner = false;
            string winningMaterial = "";

            while (true)
            {
                string[] splitedInput = input.Split();

                for (int i = 0; i < splitedInput.Length; i += 2)
                {
                    int currentMarks = int.Parse(splitedInput[i]);
                    string currentMaterial = splitedInput[i + 1].ToLower();

                    bool isKeyMaterial = currentMaterial == "shards" ||
                        currentMaterial == "fragments" ||
                        currentMaterial == "motes";

                    if (isKeyMaterial)
                    {
                        keyMaterials[currentMaterial] += currentMarks;

                        if (keyMaterials[currentMaterial] >= 250)
                        {
                            hasWinner = true;
                            keyMaterials[currentMaterial] -= 250;
                            winningMaterial = currentMaterial;
                            break;
                        }
                    }

                    if (!junk.ContainsKey(currentMaterial) && !isKeyMaterial)
                    {
                        junk[currentMaterial] = 0;
                    }

                    if (!isKeyMaterial)
                    {
                        junk[currentMaterial] += currentMarks;
                    }
                }
                if (hasWinner)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (winningMaterial == "shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (winningMaterial == "fragments")
            {
                Console.WriteLine($"Valanyr obtained!");
            }
            else if (winningMaterial == "motes")
            {
                Console.WriteLine($"Dragonwrath obtained!");
            }

            var orderedKeyMaterial = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var material in orderedKeyMaterial)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            var orderedJunkMaterials = junk.OrderBy(x => x.Key);

            foreach (var material in orderedJunkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
