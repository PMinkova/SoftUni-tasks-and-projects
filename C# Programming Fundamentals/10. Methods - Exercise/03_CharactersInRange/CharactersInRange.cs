using System;

namespace _03_CharactersInRange
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintCharsInRange(start, end);
        }

        static void PrintCharsInRange(char start, char end)
        {

            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }

                Console.WriteLine();
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
