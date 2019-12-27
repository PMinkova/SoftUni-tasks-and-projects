using System;
using System.Collections.Generic;

namespace P05_RecordUniqueNames
{
    class RecordUniquenames
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

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
