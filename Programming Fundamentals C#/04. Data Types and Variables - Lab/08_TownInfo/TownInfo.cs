﻿using System;

namespace _08_TownInfo
{
    class TownInfo
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
