using System;

namespace P02_RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
         
            Console.WriteLine(Math.Round(radians * 180 / Math.PI));
        }
    }
}
