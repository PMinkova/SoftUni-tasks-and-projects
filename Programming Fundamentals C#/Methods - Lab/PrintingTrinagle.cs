using System;

namespace _04_PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintLine(row);
            }

            for (int row = number - 1; row > 0; row--)
            {
                PrintLine(row);
            }
        }

       
    }
}
