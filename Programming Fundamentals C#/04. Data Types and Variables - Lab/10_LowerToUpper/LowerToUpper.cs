using System;

namespace _10_LowerToUpper
{
    class LowerToUpper
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if (input == input.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
