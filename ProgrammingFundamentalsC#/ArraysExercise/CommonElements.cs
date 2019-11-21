using System;
using System.Linq;

namespace _02_CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray.Contains(secondArray[i]))
                {
                    Console.Write(secondArray[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
