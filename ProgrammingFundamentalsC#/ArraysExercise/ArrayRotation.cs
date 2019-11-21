using System;
using System.Linq;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations % numbers.Length; i++)
            {
                string first = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = first;
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
