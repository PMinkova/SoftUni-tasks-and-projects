using System;

namespace _01_NumberInRange1To100
{
    class NumberInRange1To100
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || 100 < number)
            {
                Console.WriteLine("Invalide number!");

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is" + number);
        }
    }
}
