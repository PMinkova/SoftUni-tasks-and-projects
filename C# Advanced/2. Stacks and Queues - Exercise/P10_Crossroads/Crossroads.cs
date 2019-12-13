using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace P10_Crossroads
{
    class Crossroads
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            int greenLightSecondsLeft = greenLightDuration;  // overwrite the time of the green and yellow light
            int yellowLightSecondsLeft = freeWindowDuration; 

            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;

            bool getsHit = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (input == "green")
                {
                    while (cars.Any()) 
                    {
                        string car = cars.Peek();

                        bool hasPassedSuccessfullyOnGreen = car.Length <= greenLightSecondsLeft;
                        bool hasExitSuccessfullyOnYellow =
                            car.Length <= greenLightSecondsLeft + yellowLightSecondsLeft && greenLightSecondsLeft > 0;
                        bool hasNotEnteredTheCrossRoad = greenLightSecondsLeft == 0;

                        if (hasPassedSuccessfullyOnGreen)
                        {
                            cars.Dequeue();
                            totalCarsPassed++;
                            greenLightSecondsLeft -= car.Length;
                        } 
                        else if (hasExitSuccessfullyOnYellow)
                        {
                            cars.Dequeue();
                            totalCarsPassed++; 
                            yellowLightSecondsLeft -= (car.Length - greenLightSecondsLeft);
                            greenLightSecondsLeft = 0;
                        }
                        else if (hasNotEnteredTheCrossRoad)
                        {
                            break;
                        }
                        else
                        {
                            int crashIndex = greenLightSecondsLeft + yellowLightSecondsLeft;
                            char characterHit = car[crashIndex];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {characterHit}.");
                            getsHit = true;
                            break;
                        }
                    }

                    greenLightSecondsLeft = greenLightDuration;
                    yellowLightSecondsLeft = freeWindowDuration;
                }
                else
                {
                    string currentCar = input;
                    cars.Enqueue(currentCar);
                }

                if (getsHit)
                {
                    break;
                }
            }

            if (!getsHit)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
            }
        }
    }
}
