namespace Vehicles.Models
{
    using Exceptions;
    using System;
    public class Bus : Vehicle
    {
        private const double FuelConsumptionIncrementWithPeopleOnBoard = 1.4;
        

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionIncrementWithPeopleOnBoard)
        {

        }

        public string DriveEmpty(double distance)
        {
            var necessaryFuel = (this.FuelConsumption - FuelConsumptionIncrementWithPeopleOnBoard) * distance;

            if (this.FuelQuantity < necessaryFuel)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InsufficientFuel, this.GetType().Name));
            }

            this.FuelQuantity -= necessaryFuel;
            this.TankCapacity += necessaryFuel;
                
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}