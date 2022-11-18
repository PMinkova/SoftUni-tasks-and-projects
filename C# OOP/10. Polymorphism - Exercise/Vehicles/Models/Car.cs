namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        // create a private const and pass it to the base constructor - encapsulation

        private const double FuelConsumptionIncrement = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption, FuelConsumptionIncrement)
        {

        }
    }
}
