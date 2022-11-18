namespace Vehicles.Models
{
    using System;

    using Contracts;
    using Exceptions;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double fuelConsumptionIncrement)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; }

        public double TankCapacity { get; protected set; }

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
            if (liters <= 0)
            {
                throw new ZeroOrNegativeNumberException();
            }

            if (this.TankCapacity < liters + this.FuelQuantity)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InsufficientTankCapacity, liters));
            }

            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
