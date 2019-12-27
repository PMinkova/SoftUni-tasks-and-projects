using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ReverseАndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % n == 0;

            numbers.Where(x => !isDivisible(x))
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
