using System;

namespace _05_AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int sum = Sum(numOne, numTwo);
            int result = Subtract(sum, numThree);

            Console.WriteLine(result);
        }

        static int Sum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        static int Subtract(int sum, int numThree)
        {
            int result = sum - numThree;
            return result;   
        }
    }
}
