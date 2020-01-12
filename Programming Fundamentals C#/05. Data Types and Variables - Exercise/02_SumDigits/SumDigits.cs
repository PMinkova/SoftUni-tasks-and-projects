using System;

namespace _02_SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            // First variant:
            //string number = Console.ReadLine();
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += int.Parse(number[i].ToString());
            //}
            //Console.WriteLine(sum);

            //Second Variant:

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
