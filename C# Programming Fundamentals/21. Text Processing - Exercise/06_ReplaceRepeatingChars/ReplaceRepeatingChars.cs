using System;
using System.Linq;

namespace ConsoleApp1
{
    class ReplaceRepeatingChars
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            for (int i = 1; i < text.Length; i++)
            {
                char previous = text[i - 1];
                char current = text[i];

                if (current == previous)
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(text);
        }

    }
}
