using System;

namespace _02_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double triangleArea = a * h / 2;
            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
