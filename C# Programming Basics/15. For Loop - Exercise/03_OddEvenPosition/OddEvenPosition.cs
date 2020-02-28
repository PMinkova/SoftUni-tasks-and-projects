using System;

namespace _03_OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMin = 10000000;
            double oddMax = -10000000;
            double evenMin = 10000000;
            double evenMax = -10000000;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
            }
            if (oddSum == 0)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,"); 
            }
            else
            {
                Console.WriteLine("OddSum={0:F2},", oddSum);
                Console.WriteLine("OddMin={0:F2},", oddMin);
                Console.WriteLine("OddMax={0:F2},", oddMax);
            }

            if (evenSum == 0)
            {
                Console.WriteLine("EvenSum={0:F2},", evenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenSum={0:F2},", evenSum);
                Console.WriteLine("EvenMin={0:F2},", evenMin);
                Console.WriteLine("EvenMax={0:F2}", evenMax);
            }
            
        }
    }
}
