using System;

namespace _05_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (200 <= number && number <= 399)
                {
                    p2++;
                }
                else if (400 <= number && number <= 599)
                {
                    p3++;
                }
                else if (600 <= number && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            p1 = p1 * 100 / n;
            p2 = p2 * 100 / n;
            p3 = p3 * 100 / n;
            p4 = p4 * 100 / n;
            p5 = p5 * 100 / n;
        
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
