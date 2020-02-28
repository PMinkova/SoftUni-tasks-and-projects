using System;

namespace _05_MinValue
{
    class MinValue
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int minValue = int.MaxValue;

            while (counter < numberCount)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minValue)
                {
                    minValue = number;
                }

                counter++;
            }

            Console.WriteLine(minValue);
        }
    }
}
