using System;

namespace _06_MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleCharacter(text);
        }

        static void PrintMiddleCharacter(string text)
        {
            int length = text.Length;
            string result = "";
            int middle = length / 2;

            if (length % 2 == 0)
            {
                result = text[middle - 1].ToString() + text[middle];
            }
            else
            {
                result = text[middle].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
