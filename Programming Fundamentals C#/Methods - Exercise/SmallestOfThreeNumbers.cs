using System;

namespace _01_SmallestOfThreeNumbers
{
    class Program
    {
        static int PrintSmallest(int a, int b)
        {
            int minNumber = 0;

            if (a < b)
            {
                minNumber = a;
            }
            else
            {
                minNumber = b;
            }

            return minNumber;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstResult = PrintSmallest(a, b);
            int smallestNumber = PrintSmallest(firstResult, c);

            Console.WriteLine(smallestNumber);

        }
    }
}
