namespace Vehicles.Factories.Contracts
{
    using Models.Contracts;

    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string vehicleType, double vehicleFuelQuantity, double vehicleFuelConsumption, double tankCapacity);
    }
}