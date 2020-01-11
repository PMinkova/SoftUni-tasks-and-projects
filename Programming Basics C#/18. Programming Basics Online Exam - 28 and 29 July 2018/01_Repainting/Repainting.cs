using System;

namespace _01_Repainting
{
    class Repainting
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double nylonSum = (nylon + 2) * 1.50;
            double paintSum = paint * 1.10 * 14.50;
            double plasticBagSum = 0.40;
            double diluentSum = diluent * 5;

            double materialsSum = nylonSum + paintSum + plasticBagSum + diluentSum;
            double moneyPerHour = 0.30 * materialsSum;
            double moneyForCraftsman = workingHours * moneyPerHour;
            double totalExpenses = materialsSum + moneyForCraftsman;

            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");
        }
    }
}
