﻿namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        private const double InitialFuelAvailable = 80;
        private const double DefaultFuelConsumptionPerRace = 10;
        public SuperCar(string make, string model, string VIN, int horsePower) 
            : base(make, model, VIN, horsePower, InitialFuelAvailable, DefaultFuelConsumptionPerRace)
        {

        }

    }
}
