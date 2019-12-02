using System;
using System.Linq;
using System.Collections.Generic;

namespace _06_VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue()
        {
            Vehicles = new List<Vehicle>();
        }

        public List<Vehicle> Vehicles { get; set; }
    }


    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            TypeOfVehicle = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string TypeOfVehicle { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    class VehicleCatalog
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Catalogue vehicles = new Catalogue();

            while (input != "End")
            {
                string[] data = input.Split();

                string typeOfVehicle = data[0];
                string model = data[1];
                string color = data[2];
                int horsePower = int.Parse(data[3]);

                vehicles.Vehicles.Add(new Vehicle(typeOfVehicle, model, color, horsePower));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Vehicles)
                {
                    if (vehicle.Model == input)
                    {
                        if (vehicle.TypeOfVehicle == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                        }

                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }

                input = Console.ReadLine();
            }

            int carsHorsePowerSum = 0;
            int trucksHorsepowerSum = 0;

            foreach (var vehicle in vehicles.Vehicles)
            {
                if (vehicle.TypeOfVehicle == "car")
                {
                    carsHorsePowerSum += vehicle.Horsepower;
                }
                else
                {
                    trucksHorsepowerSum += vehicle.Horsepower;
                }
            }

            int carsCount = vehicles.Vehicles.Where(x => x.TypeOfVehicle == "car").Count();

            if (carsCount > 0)
            {
                double carsAvgHorsepower = (double)carsHorsePowerSum / carsCount;
                Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            int trucksCount = vehicles.Vehicles.Where(x => x.TypeOfVehicle == "truck").Count();

            if (trucksCount > 0)
            {
                double trucksAvgHorsepower = (double)trucksHorsepowerSum / trucksCount;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }

    }
}
