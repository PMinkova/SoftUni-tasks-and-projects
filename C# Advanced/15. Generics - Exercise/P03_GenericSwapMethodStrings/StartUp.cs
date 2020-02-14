using System;
using System.Collections.Generic;

namespace P03_GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                box.Values.Add(input);
            }

            var indexes = Console.ReadLine().Split();

            var firstInex = int.Parse(indexes[0]);
            var secondIndex = int.Parse(indexes[1]);

            box.Swap(firstInex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
