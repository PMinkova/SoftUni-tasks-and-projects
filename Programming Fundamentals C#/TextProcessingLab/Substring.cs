using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine().ToLower();

            string result = string.Empty;
           
            int startIndex = secondString.IndexOf(firstString);

            while (startIndex != -1)
            {
                result = secondString.Remove(startIndex, firstString.Length);
                startIndex = result.IndexOf(firstString);
                secondString = result;
            }

            Console.WriteLine(result);
        }
    }
}
