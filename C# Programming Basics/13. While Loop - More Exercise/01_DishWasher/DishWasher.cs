using System;

namespace WhileLoopMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentCount = int.Parse(Console.ReadLine());
            int detergentMl = detergentCount * 750;
            string command = Console.ReadLine();
            int dishes = 0;
            int pots = 0;
            int counter = 1;
            int usedDetergentMl = 0;
            bool isNotEnough = false;


            while (command != "End")
            {
                int goods = int.Parse(command);
                if (counter % 3 == 0)
                {
                    usedDetergentMl = usedDetergentMl + (15 * goods);
                    pots += goods;
                }
                else
                {
                    dishes += goods;
                    usedDetergentMl = usedDetergentMl + (5 * goods);
                }

                if (usedDetergentMl > detergentMl)
                {
                    isNotEnough = true;
                    break;
                }

                counter++;
                command = Console.ReadLine();
            }

            int diff = Math.Abs(detergentMl - usedDetergentMl);

            if (isNotEnough)
            {
                Console.WriteLine($"Not enough detergent, {diff} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {diff} ml.");
            }

        }
    }
}
