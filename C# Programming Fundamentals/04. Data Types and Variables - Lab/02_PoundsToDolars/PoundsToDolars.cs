using System;

namespace _02_PoundsToDolars
{
    class PoundsToDolars
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());

            decimal dollars = britishPounds * 1.31m;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
