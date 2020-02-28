using System;

namespace _08_Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int volumeRoom = widht * lenght * hight;
            int volumBoxes = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);

                volumBoxes += boxes;

                if (volumBoxes > volumeRoom)
                {
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", volumBoxes - volumeRoom);
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine("{0} Cubic meters left.", volumeRoom - volumBoxes);
            }
        }
    }
}
