using System;

namespace P08.YardGreening
{
    class YardGreening
    {
        static void Main(string[] args)
        {
            double squareMeter = double.Parse(Console.ReadLine());
            double price = 7.61 * squareMeter;
            double discount = 0.18 * price;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is: {0:F2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
        }
    }
}
