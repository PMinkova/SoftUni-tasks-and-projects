using System;

namespace _01_SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int printFirst = 0;
            int printMiddle = 0;
            int printLast = 0;

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                printFirst = firstNumber;

                if (secondNumber > thirdNumber)
                {
                    printMiddle = secondNumber;
                    printLast = thirdNumber;
                }
                else
                {
                    printMiddle = thirdNumber;
                    printLast = secondNumber;
                }
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                printFirst = secondNumber;
                if (firstNumber > thirdNumber)
                {
                    printMiddle = firstNumber;
                    printLast = thirdNumber;
                }
                else
                {
                    printMiddle = thirdNumber;
                    printLast = firstNumber;
                }
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                printFirst = thirdNumber;

                if (firstNumber > secondNumber)
                {
                    printMiddle = firstNumber;
                    printLast = secondNumber;
                }
                else
                {
                    printMiddle = secondNumber;
                    printLast = firstNumber;
                }
            }

            Console.WriteLine(printFirst);
            Console.WriteLine(printMiddle);
            Console.WriteLine(printLast);
        }
    }
}
