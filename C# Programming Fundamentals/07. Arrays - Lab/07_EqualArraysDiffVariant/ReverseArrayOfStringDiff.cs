using System;

namespace _07_EqualArraysDiffVariant
{
    class ReverseArrayOfStringDiff
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            string[] reversed = new string[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                reversed[i] = elements[elements.Length - i - 1]; 
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }   
        }
    }
}
