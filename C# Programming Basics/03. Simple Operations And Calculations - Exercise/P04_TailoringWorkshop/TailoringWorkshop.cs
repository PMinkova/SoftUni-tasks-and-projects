using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double areaCover = (tableLenght + 0.6) * (tableWidth + 0.6);
            double areaSquare = 0.5 * tableLenght * 0.5 * tableLenght;

            double priceCoverUsd = tablesCount * 7 * areaCover;
            double priceSquareUsd = tablesCount * 9 * areaSquare;
            double priceUsdAll = priceSquareUsd + priceCoverUsd;
            double priceBgnAll = priceUsdAll * 1.85;

            Console.WriteLine("{0:F2} USD", priceUsdAll);
            Console.WriteLine("{0:F2} BGN", priceBgnAll);

            


        }
    }
}
