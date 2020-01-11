using System;

namespace _02_HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;

                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }
            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxNumber);
            }
            else
            {
                int diff = Math.Abs(sum - maxNumber - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
