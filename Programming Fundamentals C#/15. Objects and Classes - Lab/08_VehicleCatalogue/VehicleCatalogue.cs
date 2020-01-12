using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

    }

    class VehicleCatalogue
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Catalog cars = new Catalog();   // the instance of the class could be created when adding in the list -> 
            Catalog trucks = new Catalog(); // catalog.Cars.Add(new Car(brand, model, horsePower));

            while (input != "end")
            {
                string[] data = input.Split("/");

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int horsePower = int.Parse(data[3]);
                int weight = int.Parse(data[3]);

                if (type == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    trucks.Trucks.Add(truck);
                }
                else
                {
                    cars.Cars.Add(new Car { Brand = brand, Model = model, HorsePower = horsePower }); // could be set in a Constructor 
                    //  catalog.Cars.Add(new Car(brand, model, horsePower));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Cars:");

            foreach (var car in cars.Cars.OrderBy(car => car.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (var truck in trucks.Trucks.OrderBy(truck => truck.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
