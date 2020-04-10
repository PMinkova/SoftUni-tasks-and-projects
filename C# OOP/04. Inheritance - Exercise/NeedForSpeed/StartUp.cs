using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            var car = new Car(110, 10);
            Console.WriteLine(car.FuelConsumption);
        }
    }
}
