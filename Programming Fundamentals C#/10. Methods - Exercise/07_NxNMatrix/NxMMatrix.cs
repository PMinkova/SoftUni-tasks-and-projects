using System;

namespace _07_NxNMatrix
{
    class NxMMatrix
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNxNMatrix(number);
        }

        static void PrintNxNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
