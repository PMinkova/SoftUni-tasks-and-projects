namespace Vehicles.Exceptions
{
    using System;

    public class InvalidVehicleTypeException : Exception
    {
        private const string DefaultMessage = "Vehicle type not supported!";

        public InvalidVehicleTypeException() 
            : base()
        {

        }

        public InvalidVehicleTypeException(string text) 
            : base(text)

        {

        }

    }
}
