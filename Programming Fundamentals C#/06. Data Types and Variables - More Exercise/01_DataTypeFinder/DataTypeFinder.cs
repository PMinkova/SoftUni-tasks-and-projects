using System;

namespace _01_DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isIntiger = int.TryParse(input, out int intValue);
                bool isDouble = double.TryParse(input, out double doubleValue);
                bool isChar = char.TryParse(input, out char charValue);
                bool isBool = bool.TryParse(input, out bool boolValue);


                if (isIntiger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
