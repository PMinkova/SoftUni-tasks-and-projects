using System;

namespace _02_LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int startLetter = 'a';
            int lastLetter = 'z';

            for (int i = startLetter; i <= lastLetter; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
