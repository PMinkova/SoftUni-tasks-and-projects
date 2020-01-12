using System;

namespace _07_RepeatString
{
    class RepeatString
    {
        static string GetRepeatedString(string word, int number)
        {
            string result = "";

            for (int i = 0; i < number; i++)
            {
                result += word;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = GetRepeatedString(word, number);
            Console.WriteLine(result);
        }
    }
}
