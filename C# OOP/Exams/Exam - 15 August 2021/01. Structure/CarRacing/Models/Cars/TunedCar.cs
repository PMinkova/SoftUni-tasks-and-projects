namespace CarRacing.Models.Cars
{
    using System;

    public class TunedCar : Car
    {
        private const double InitialFuelAvailable = 65;
        private const double DefaultFuelConsumptionPerRace = 7.5;
        private const double ReduceHorsePowerCoefficient = 0.03;
        public TunedCar(string make, string model, string VIN, int horsePower)
            : base(make, model, VIN, horsePower, InitialFuelAvailable, DefaultFuelConsumptionPerRace)
        {

        }

        public override void Drive()
        {
            base.Drive();
            this.HorsePower = (int)Math.Round(this.HorsePower - this.HorsePower * ReduceHorsePowerCoefficient); // Math.Round?
        }
    }
}
