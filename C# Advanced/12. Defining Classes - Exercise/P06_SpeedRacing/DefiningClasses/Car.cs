using System;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;

            this.TravelledDistance = 0.0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(int amountOfKm) 
        {
            double requiredFuel = amountOfKm * this.FuelConsumptionPerKilometer;
            bool carCanMove = this.FuelAmount - requiredFuel >= 0;

            if (carCanMove)
            {
                this.TravelledDistance += amountOfKm;
                this.FuelAmount -= requiredFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
