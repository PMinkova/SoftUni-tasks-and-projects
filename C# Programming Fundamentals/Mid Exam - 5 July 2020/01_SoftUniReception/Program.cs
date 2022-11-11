using System;

namespace _01_SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            double hours = studentsCount * 1.00 / (firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency);
            hours = Math.Ceiling(hours);

            for (int i = 1; i <= hours; i++)
            {
                if (i % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
