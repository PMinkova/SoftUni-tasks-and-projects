using System;
using System.Runtime.CompilerServices;

namespace P05_GenericCountMethodStrings
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

            var value = Console.ReadLine();

            Console.WriteLine(box.CountElementsGraterThanValue(value));
        }
    }
}
