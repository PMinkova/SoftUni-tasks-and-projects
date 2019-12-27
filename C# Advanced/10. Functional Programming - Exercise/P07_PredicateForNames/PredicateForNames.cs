using System;
using System.Linq;

namespace P07_PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            Predicate<string> hasLessOrEqualLength = x => x.Length <= nameLength;

            Console.ReadLine()
                .Split()
                .Where(x => hasLessOrEqualLength(x))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
