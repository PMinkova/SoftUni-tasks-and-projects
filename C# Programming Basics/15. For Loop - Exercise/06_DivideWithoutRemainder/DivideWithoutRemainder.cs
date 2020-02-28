﻿using System;

namespace _06_DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                    if (number % 4 == 0)
                    {
                        p3++;
                    }
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
              
            }

            p1 = p1 * 100 / n;
            p2 = p2 * 100 / n;
            p3 = p3 * 100 / n;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
