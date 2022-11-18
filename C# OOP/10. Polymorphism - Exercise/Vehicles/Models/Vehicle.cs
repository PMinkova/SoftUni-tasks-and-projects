namespace Vehicles.Models
{
    using System;

    using Contracts;
    using Exceptions;

    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; }

        public string Drive(double distance)
        {
            var necessaryFuel = this.FuelConsumption * distance;

            if (this.FuelQuantity < necessaryFuel)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InsufficientFuel, this.GetType().Name));
            }

            this.FuelQuantity -= necessaryFuel;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
