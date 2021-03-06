﻿using System;
using System.Linq;

namespace _01_SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            String result = "";

            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
