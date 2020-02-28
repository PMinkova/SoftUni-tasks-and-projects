using System;

namespace _09_MultiplyBy2
{
    class MultiplyBy2
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double result = 0;

            while (n >= 0)
            {
                result = n * 2;
                Console.WriteLine($"Result: {result:f2}");
                n = double.Parse(Console.ReadLine());
            }

            if (n < 0)
            {
                Console.WriteLine("Negative number!");
            }
        }
    }
}
