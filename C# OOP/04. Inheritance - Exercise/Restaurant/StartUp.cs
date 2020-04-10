using System;
using System.Globalization;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main()
        {
            var cake = new Cake("pepe");
            cake.Price = 4;
            Console.WriteLine(cake.Price);
        }
    }
}