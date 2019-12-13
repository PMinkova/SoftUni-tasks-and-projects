using System;

namespace _05_InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((100 <= number && number <= 200) || number == 0)
            {
               
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
