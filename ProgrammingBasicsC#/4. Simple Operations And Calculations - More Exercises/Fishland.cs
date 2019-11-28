using System;

namespace _06_Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            // mackerel - скумрия
            // sprat - цаца
            // Atlantic bonito - паламуд
            // Horse Mackerel - сафрид
            // mussels - миди

            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());

            double atlanticBonitoQantity = double.Parse(Console.ReadLine());
            double horseMackerelQuantity = double.Parse(Console.ReadLine());
            int musselsQuantity = int.Parse(Console.ReadLine());

            double atlanticBonitoPrice = mackerelPrice * 1.6;
            double horseMаckerelPrice = spratPrice * 1.8;

            double musselsTotalPrice = 7.50 * musselsQuantity;
            double atlanticBonitoTotalPrice = atlanticBonitoQantity * atlanticBonitoPrice;
            double horseMаckerelTotalPrice = horseMackerelQuantity * horseMаckerelPrice;

            double totalPrice = musselsTotalPrice + atlanticBonitoTotalPrice + horseMаckerelTotalPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
