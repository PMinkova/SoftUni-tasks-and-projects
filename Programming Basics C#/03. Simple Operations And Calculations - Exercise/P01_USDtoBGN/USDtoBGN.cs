using System;

namespace P01_USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;

            Console.WriteLine("{0:F}", bgn);
        }
    }
}
