using System;

namespace P07_AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPriceLiter = double.Parse(Console.ReadLine());

            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double brandyLiters = double.Parse(Console.ReadLine());
            double whiskyLiters = double.Parse(Console.ReadLine());

            double brandyPriceLiter = whiskyPriceLiter / 2;
            double winePriceLiter = brandyPriceLiter - (brandyPriceLiter * 0.4);
            double beerPriceLiter = brandyPriceLiter - (brandyPriceLiter * 0.8);

            double brandyPrice = brandyPriceLiter * brandyLiters;
            double winePrice = winePriceLiter * wineLiters;
            double beerPrice = beerPriceLiter * beerLiters;
            double whiskyPrice = whiskyPriceLiter * whiskyLiters;

            double amountAll = brandyPrice + winePrice + beerPrice + whiskyPrice;

            Console.WriteLine("{0:F2}", amountAll);
        }
    }
}
