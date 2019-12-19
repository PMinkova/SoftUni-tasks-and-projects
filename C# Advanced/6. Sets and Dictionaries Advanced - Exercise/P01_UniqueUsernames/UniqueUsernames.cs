using System;
using System.Collections.Generic;

namespace P01_UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
