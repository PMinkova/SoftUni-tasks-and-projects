using System;

namespace _01_ReverseStrings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string word = input;

                string reversedWord = String.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                Console.WriteLine(word + " = " + reversedWord);

                input = Console.ReadLine();
            }
        }
    }
}
