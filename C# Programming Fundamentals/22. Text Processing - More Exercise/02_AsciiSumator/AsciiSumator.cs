using System;

namespace _02_AsciiSumator
{
    class AsciiSumator
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string randomString = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < randomString.Length; i++)
            {
                char currentLetter = randomString[i];

                bool isBetweenBothSymbols = firstChar < currentLetter && currentLetter < secondChar;

                if (isBetweenBothSymbols)
                {
                    result += currentLetter;
                }
            }

            Console.WriteLine(result);
        }
    }
}
