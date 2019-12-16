using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] splitedInput = input.Split(", ");

                string direction = splitedInput[0];
                string carNumber = splitedInput[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }

            if (parkingLot.Any())
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
