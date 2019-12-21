using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace P04_AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            Func<double, double> addVAT = p => p * 1.2;  // p -> price

            Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(addVAT)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p:f2}"));
        }
    }
}
