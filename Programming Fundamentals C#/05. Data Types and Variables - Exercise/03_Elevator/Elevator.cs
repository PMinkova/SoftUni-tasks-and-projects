using System;

namespace _03_Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(persons / (double)capacity);
            Console.WriteLine(courses);
        }
    }
}
