namespace Vehicles.Models
{
    using System;

    using Exceptions;
    public class Truck : Vehicle
    {
        private const double FuelConsumptionIncrement = 1.6;
        private const double RefuelLossCoefficient = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionIncrement)
        {

        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ZeroOrNegativeNumberException();
            }

            if (this.TankCapacity < liters + this.FuelQuantity)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InsufficientTankCapacity, liters));
            }

            base.Refuel(liters * RefuelLossCoefficient);
        }
    }
}
