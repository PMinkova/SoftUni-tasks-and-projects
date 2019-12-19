using System;
using System.Collections.Generic;

namespace P03_PeriodicTable
{
    class Periodictable
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalElements = new SortedSet<string>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    string currentElement = elements[j];

                    chemicalElements.Add(currentElement);
                }
            }

            foreach (var element in chemicalElements)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
