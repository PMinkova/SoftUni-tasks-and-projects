﻿using System;

namespace _01_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine("baby");
            }
            else if (age < 14)
            {
                Console.WriteLine("child");
            }
            else if (age < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (age < 66)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
