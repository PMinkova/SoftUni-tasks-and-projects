namespace Vehicles.Factories
{
    using Contracts;
    using Exceptions;
    using Models;
    using Models.Contracts;

    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType, double vehicleFuelQuantity, double vehicleFuelConsumption, double tankCapacity)
        {
            IVehicle vehicle;

            if (vehicleType == "Car")
            {
                vehicle = new Car(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus")
            {
                vehicle = new Bus(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
            else
            {
                throw new InvalidVehicleTypeException();
            }

            return vehicle;
        }
    }
}