using System;

namespace _01_DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int number = int.Parse(Console.ReadLine());

                PrintResult(number);
            }
            else if (type == "real")
            {
                double number = double.Parse(Console.ReadLine());
                PrintResult(number);
            }
            else if (type == "string")
            {
                string text = Console.ReadLine();
                PrintResult(text);
            }
        }

        static void PrintResult(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }

        static void PrintResult(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void PrintResult(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
