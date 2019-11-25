using System;
using System.Linq;
using System.Collections.Generic;

namespace _07_AppendArrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<string> lists = line.Split("|").ToList();
            List<string> newList = new List<string>();

            lists.Reverse();

            for (int i = 0; i < lists.Count; i++)
            {
                string currentNumbers = lists[i];
                List<string> current = currentNumbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                newList.AddRange(current);
            }

            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
