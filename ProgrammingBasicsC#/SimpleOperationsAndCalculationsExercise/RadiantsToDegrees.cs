using System;

namespace RadiansToDegrees
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
