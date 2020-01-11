using System;

namespace demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int previousSum = 0;
            int maxDiff = 0;


            for (int i = 0; i < n; i++)
            {

                int firtsNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int currentSum = firtsNumber + secondNumber;

                int currentDiff = Math.Abs(currentSum - previousSum);

                if (currentDiff > maxDiff && i > 0)
                {
                    maxDiff = currentDiff;
                }
                previousSum = currentSum;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
