using System;

namespace _04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                foreach (var bannedWord in words)
                {
                    if (text.Contains(bannedWord))
                    {
                        text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                    }
                }  
            }

            Console.WriteLine(text);
        }
    }
}
