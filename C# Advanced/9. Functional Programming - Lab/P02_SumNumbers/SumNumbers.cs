using System;
using System.Linq;

namespace P02_SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Func<string, int> parser = int.Parse;

            int[] numbers = input
                .Split(", ")
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }

    
}
