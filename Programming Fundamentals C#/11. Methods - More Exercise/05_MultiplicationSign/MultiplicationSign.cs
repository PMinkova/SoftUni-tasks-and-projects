using System;

namespace _05_MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());
            double thirdNumber = int.Parse(Console.ReadLine());

            PrintSign(firstNumber, secondNumber, thirdNumber);
        }

        static void PrintSign(double first, double second, double third)
        {
            bool isZero = first == 0 || second == 0 || third == 0;

            bool isPositive = first > 0 && second > 0 && third > 0 ||
                first < 0 && second < 0 && third > 0 || second < 0 &&
                third < 0 && third > 0 || first < 0 && third < 0 && second > 0;

            if (isZero)
            {
                Console.WriteLine("zero");
            }
            else if (isPositive)
            {
                Console.WriteLine("positive");
            }
            else 
            {
                Console.WriteLine("negative");
            }           
        } 
    }
}
