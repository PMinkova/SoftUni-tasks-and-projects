using System;

namespace _12_EvenNumber
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            int evenNuber = int.Parse(Console.ReadLine());

            while (evenNuber % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                evenNuber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(evenNuber)}");
        }
    }
}
