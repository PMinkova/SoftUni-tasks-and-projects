using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunc = (x, y) => x.CompareTo(y);
            Action<int[], int[]> print = (x, y) => 
                Console.WriteLine($"{String.Join(" ", x)} {String.Join(" ", y)}");

            var evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
            var oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();

            Array.Sort(evenNumbers, new Comparison<int>(sortFunc));
            Array.Sort(oddNumbers, new Comparison<int>(sortFunc));

            print(evenNumbers, oddNumbers);
        }
    }
}
