using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Channels;

namespace P01_SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
