using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    { 
        // fields:
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        // Constructor:
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        // Constructor:
        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        // Constructor:
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        //Constructor:
        public Car(string make, string model, int year, double fuelQuantity, 
            double fuelConsumption, Engine engine, Tire[] tires)
            :this (make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        // Property:
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        // Property
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        // Property
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        //Property
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }
        // Property
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        // Property
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; } // Be careful with the Upper Letters!!! --> StackOverflow exception (it has to be lower Letter)
        }

        // Property
        public Tire[] Tires 
        {
            get { return this.tires; }
            set { this.tires = value; } 
        }

        // Method
        public void Drive(double distance)
        {
            bool hasEnoughFuel = this.FuelQuantity - (distance * this.FuelConsumption / 100) > 0;

            if (hasEnoughFuel)
            {
                this.FuelQuantity -= (distance * this.FuelConsumption / 100);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        // Method
        public string WhoAmI()
        {
            var result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel: {this.FuelQuantity:F2}L");

            return result.ToString();
        }
    }
}
