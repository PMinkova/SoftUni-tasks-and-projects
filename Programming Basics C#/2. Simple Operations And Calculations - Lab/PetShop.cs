using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double amount = 2.50 * dogs + 4 * animals;

            Console.WriteLine("{0:F2} lv.",amount);
        }
    }
}
