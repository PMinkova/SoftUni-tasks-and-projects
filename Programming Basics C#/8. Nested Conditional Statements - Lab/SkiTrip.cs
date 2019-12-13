using System;

namespace _08_SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStayinginHotel = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            int nightsInHotel = daysStayinginHotel - 1;
            double priceForRoom = nightsInHotel * 18;
            double priceForApartment = nightsInHotel * 25;
            double priceForPresidentApartment = nightsInHotel * 35;
            double price = -1;

            if (roomType == "room for one person")
            {
                price = priceForRoom;
            }
            else if (roomType == "apartment")
            {
                if (daysStayinginHotel < 10)
                {
                    price = priceForApartment - (0.30 * priceForApartment);
                }
                else if (10 <= daysStayinginHotel && daysStayinginHotel <= 15)
                {
                    price = priceForApartment - (0.35 * priceForApartment);
                }
                else if (daysStayinginHotel > 15)
                {
                    price = priceForApartment - (0.50 * priceForApartment);
                }
            }
            else if (roomType == "president apartment")
            {
                if (daysStayinginHotel < 10)
                {
                    price = priceForPresidentApartment - (0.10 * priceForPresidentApartment);
                }
                else if (10 <= daysStayinginHotel && daysStayinginHotel <= 15)
                {
                    price = priceForPresidentApartment - (0.15 * priceForPresidentApartment);
                }
                else if (daysStayinginHotel > 15)
                {
                    price = priceForPresidentApartment - (0.20 * priceForPresidentApartment);
                }
              
            }
            if (rating == "positive")
            {
                price = price + 0.25 * price;
            }
            else if (rating == "negative")
            {
                price = price - 0.1 * price;
            }

            Console.WriteLine("{0:F2}", price);
        }
    }
}
