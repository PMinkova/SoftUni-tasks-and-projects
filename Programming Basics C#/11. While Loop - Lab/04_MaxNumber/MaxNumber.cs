using System;

namespace _04_MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxValue = int.MinValue;    

            while (counter < numberCount)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxValue)
                {
                    maxValue = number;
                }

                counter++;
            }
            Console.WriteLine(maxValue);  
        }
    }
}
