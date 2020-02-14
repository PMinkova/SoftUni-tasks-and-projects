using System;
using System.Linq;

namespace P04_GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                box.Values.Add(input);
            }

            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstInex = indexes[0];
            var secondIndex = indexes[1];

            box.Swap(firstInex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
