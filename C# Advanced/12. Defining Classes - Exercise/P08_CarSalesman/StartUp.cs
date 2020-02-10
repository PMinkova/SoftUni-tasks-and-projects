using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace P08_CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new HashSet<Engine>();
            var cars = new List<Car>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = null;

                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 4)
                {
                    var displacement = int.Parse(engineInfo[2]);
                    var efficiency = engineInfo[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineInfo[2], out displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        var efficiency = engineInfo[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = null;

                var model = carInfo[0];
                var engineModel = carInfo[1];
                Engine engine = engines.First(e => e.Model == engineModel);

                if (carInfo.Length == 4)
                {
                    var weight = double.Parse(carInfo[2]);
                    var color = carInfo[3];

                    car = new Car(model, engine, weight, color);
                }
                else if (carInfo.Length == 3)
                {
                    double weigth;

                    bool hasWeigth = double.TryParse(carInfo[2], out weigth);

                    if (hasWeigth)
                    {
                        car = new Car(model, engine, weigth);
                    }
                    else
                    {
                        var color = carInfo[2];
                        car = new Car(model, engine, carInfo[2]);
                    }
                }
                else
                {
                    car = new Car(model, engine);
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
