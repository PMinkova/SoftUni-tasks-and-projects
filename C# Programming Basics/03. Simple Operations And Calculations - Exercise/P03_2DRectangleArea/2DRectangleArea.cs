﻿using System;

namespace P03_2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            double area = lenght * width;
            double perimeter = 2 * (lenght + width);

            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);

        }

    }
}
