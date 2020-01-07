using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split();

                string model = inputInfo[0];
                int speed = int.Parse(inputInfo[1]);
                int power = int.Parse(inputInfo[2]);

                int weigth = int.Parse(inputInfo[3]);
                string type = inputInfo[4];

                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int tireIndex = 5; tireIndex < inputInfo.Length; tireIndex += 2)
                {
                    double currentTirePressure = double.Parse(inputInfo[tireIndex]);
                    int currentTireAge = int.Parse(inputInfo[tireIndex + 1]);

                    Tire tire = new Tire(currentTirePressure, currentTireAge);
                    tires[counter++] = tire;
                }

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weigth, type);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else if (cargoType == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
