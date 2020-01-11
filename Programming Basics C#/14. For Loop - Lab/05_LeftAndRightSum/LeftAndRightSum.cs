using System;

namespace _05_LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += currentNumber;
                }
                else
                {
                    rightSum += currentNumber;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
