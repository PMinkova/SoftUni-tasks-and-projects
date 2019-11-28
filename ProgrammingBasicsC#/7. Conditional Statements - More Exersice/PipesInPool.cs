using System;

namespace ConditionalStatementsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolum = int.Parse(Console.ReadLine());
            int debitFirstPipe = int.Parse(Console.ReadLine());
            int debitSecondPipe = int.Parse(Console.ReadLine());
            double workingHours = double.Parse(Console.ReadLine());

            double litersFirstPipe = debitFirstPipe * workingHours;
            double litersSecondPipe = debitSecondPipe * workingHours;
            double litersTotal = litersFirstPipe + litersSecondPipe;

            double firstPipePercent = litersFirstPipe * 100 / litersTotal;
            double secondPipePercent = litersSecondPipe * 100 / litersTotal;
            double percentFilled = litersTotal * 100 / poolVolum;
            double freeSpace = litersTotal - poolVolum;

            if (poolVolum >= litersTotal)
            {
                Console.WriteLine($"The pool is {percentFilled:f2}% full.Pipe 1: {firstPipePercent:f2}%.Pipe 2: {secondPipePercent:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {workingHours} hours the pool overflows with {freeSpace:f2} liters.");
            }

        }
    }
}
