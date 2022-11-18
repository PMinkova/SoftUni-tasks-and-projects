namespace Vehicles.Exceptions
{
    using System;

    public class ZeroOrNegativeNumberException : Exception
    {
        public const string DefaultMessage = "Fuel must be a positive number";

        public ZeroOrNegativeNumberException() 
            : base(DefaultMessage)
        {
            
        }

        public ZeroOrNegativeNumberException(string text) 
            : base(text)
        {
            
        }
    }
}