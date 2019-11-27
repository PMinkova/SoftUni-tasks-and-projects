using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            numbers = numbers.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
         }
    }
}
