using System;

namespace _04_SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());
                sum += currentLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
