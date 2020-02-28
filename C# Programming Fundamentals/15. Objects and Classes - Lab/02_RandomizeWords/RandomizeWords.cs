using System;
using System.Linq;

namespace _02_RandomizeWords
{
    class RandomizeWords
    {
        private static int randomNumber;

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);

                string randomElement = words[randomIndex];
                string element = words[i];

                words[randomIndex] = element;
                words[i] = randomElement;
            }

            foreach (var element in words)
            {
                Console.WriteLine(element);
            }
        }
    }
}
