using System;

namespace _07_SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = "";

            if (groupType == "girls")
            {
                if (season == "Winter")
                {
                    price = studentsCount * 9.6 ;
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    price = studentsCount * 7.2;
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    price = studentsCount * 15;
                    sport = "Volleyball";
                }
            }
            else if (groupType == "boys")
            {
                if (season == "Winter")
                {
                    price = studentsCount * 9.6;
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    price = studentsCount * 7.2;
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    price = studentsCount * 15;
                    sport = "Football";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    price = studentsCount * 10;
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    price = studentsCount * 9.5;
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    price = studentsCount * 20;
                    sport = "Swimming";
                }
            }
            price *= nightsCount;

            if (studentsCount >= 50)
            {
                price *= 0.5;
            }
            else if (10 <= studentsCount && studentsCount < 20 )
            {
                price *= 0.95;
            }
            else if (20 <= studentsCount && studentsCount < 50)
            {
                price *= 0.85;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
