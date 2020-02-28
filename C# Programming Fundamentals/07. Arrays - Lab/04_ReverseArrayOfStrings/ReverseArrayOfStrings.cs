using System;

namespace _04_ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            for (int i = 0; i < elements.Length / 2; i++)
            {
                string first = elements[i];
                string last = elements[elements.Length - i - 1];

                elements[i] = last;
                elements[elements.Length - i - 1] = first;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}
