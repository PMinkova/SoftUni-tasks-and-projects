using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace P04_FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int startNum = numbers[0];
            int endNum = numbers[1];
            int count = endNum - startNum + 1;

            string condition = Console.ReadLine();

            List<int> result = new List<int>();

            Enumerable.Range(startNum, count)
                .Where(x => condition == "even"? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(result.Add);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
