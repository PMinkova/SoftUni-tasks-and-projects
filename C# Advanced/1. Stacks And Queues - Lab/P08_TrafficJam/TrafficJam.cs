using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P08_TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCars = 0;
            
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    sb.Append($"{totalCars} cars passed the crossroads.");
                    break;
                }
                else if (input == "green")
                {
                    int numberOfCarsToPass = Math.Min(number, cars.Count);

                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        sb.AppendLine($"{cars.Dequeue()} passed!");
                        totalCars++;
                    }
                }
                else
                {
                    string currentCar = input;
                    cars.Enqueue(currentCar);
                }
            }

            Console.WriteLine(sb);
        }
    }
}