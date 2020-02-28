using System;

namespace _06_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int pieces = cakeWidth * cakeLength;
            int piecesCounter = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                piecesCounter += int.Parse(input);

                if (piecesCounter >= pieces)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            int diff = Math.Abs(piecesCounter - pieces);

            if (piecesCounter >= pieces)
            {
                Console.WriteLine($"No more cake left! You need {diff} pieces more.");
            }
            else
            {
                Console.WriteLine($"{diff} pieces are left.");
            }
        }
    }
}
