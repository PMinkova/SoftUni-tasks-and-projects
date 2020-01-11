using System;

namespace _05AverageNumber
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            double avg = sum / n;
            Console.WriteLine(avg);
        }
    }
}
