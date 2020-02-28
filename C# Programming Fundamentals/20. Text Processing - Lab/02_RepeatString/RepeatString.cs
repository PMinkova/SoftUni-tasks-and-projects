using System;
using System.Text;

namespace _02_RepeatString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                string currentWord = array[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    result.Append(currentWord);
                }
            }

            Console.WriteLine(result);
        }
    }
}
