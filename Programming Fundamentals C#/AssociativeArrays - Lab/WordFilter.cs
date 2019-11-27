using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

        }
    }
}
