using System;
using System.Linq;

namespace P03_CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            Func<string, bool> filterUpperCase = str => char.IsUpper(str[0]);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(filterUpperCase)
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
