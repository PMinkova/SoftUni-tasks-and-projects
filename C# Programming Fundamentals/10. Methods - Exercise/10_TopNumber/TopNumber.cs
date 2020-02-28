using System;
using System.Linq;

namespace _10_TopNumber
{
    class TopNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMasterNumbers(number);
        }

        static void PrintMasterNumbers(int number)
        {
            for (int i = 8; i <= number; i++)
            {
                bool isMasterNum = false;

                string currentNumber = i.ToString();
                int sum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    sum += currentDigit;

                    if (currentDigit % 2 != 0)
                    {
                        isMasterNum = true;
                    }
                }

                if (sum % 8 == 0 && isMasterNum)
                {
                    Console.WriteLine(currentNumber);
                }            
            }
        }
    }
}
