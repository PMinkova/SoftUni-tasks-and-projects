using System;

namespace _09_PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersSinglePrice = double.Parse(Console.ReadLine());
            double robeSingelPrice = double.Parse(Console.ReadLine());
            double beltSinglePrice = double.Parse(Console.ReadLine());  

            double lightsabersTotalPrice = Math.Ceiling(studentsCount * 1.1) * lightsabersSinglePrice;
            double robesTotalPrice = studentsCount * robeSingelPrice;

            int freeBeltsCount = 0;

            for (int i = 0; i <= studentsCount; i+= 6)
            {
                if (i != 0)
                {
                    freeBeltsCount++;
                }  
            }

            double beltsTotalPrice = (studentsCount - freeBeltsCount) * beltSinglePrice;
            double totalPrice = beltsTotalPrice + robesTotalPrice + lightsabersTotalPrice;
            double difference = moneyAvailable - totalPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double moneyNeeded = Math.Abs(difference);
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
