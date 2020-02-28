using System;

namespace _09_FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            long factorielFirst = FindFactorial(first);
            long factorielSecond = FindFactorial(second);

            double result = DivideFactorials(factorielFirst, factorielSecond);

            Console.WriteLine($"{result:f2}");
        }

        static long FindFactorial(long number)
        {          
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            
            return factorial; 
        }

        static double DivideFactorials(double first, double second)
        {
            double result = first / second;

            return result;
        }
    }
}
