using System;

namespace _12_RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int totalNumber = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= totalNumber; i++)
            {
                int sum = 0;
                int number = i;

                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecial);            
            }
        }
    }
}
