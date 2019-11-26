using System;
using System.Linq;

namespace ArraysExercise
{
    class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passangers = new int[n];
           

            for (int i = 0; i < passangers.Length; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
            }

            int totalPassangers = passangers.Sum();

            Console.WriteLine(String.Join(" ", passangers));
            Console.WriteLine(totalPassangers);
        }
    }
}
