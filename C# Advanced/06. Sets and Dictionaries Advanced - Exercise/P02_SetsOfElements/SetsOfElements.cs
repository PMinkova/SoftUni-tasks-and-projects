using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace P02_SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] setslength = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = setslength[0];
            int secondSetLength = setslength[1];

            for (int i = 0; i < firstSetLength; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                firstSet.Add(currentNum);
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                secondSet.Add(currentNum);
            }

            foreach (var number in firstSet)
            {
                foreach (var element in secondSet)
                {
                    if (number == element)
                    {
                        Console.Write(number + " ");
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
