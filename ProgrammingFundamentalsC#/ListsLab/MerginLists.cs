using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    class MerginLists
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> secondList = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();

            int count = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < count; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = count; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = count; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
