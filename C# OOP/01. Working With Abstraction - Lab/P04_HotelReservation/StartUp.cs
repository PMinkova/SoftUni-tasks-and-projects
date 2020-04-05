using System;

namespace P04_HotelReservation
{
    public class StartUp
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split();
            var pricePerDay = decimal.Parse(data[0]);
            var numberOfDays = int.Parse(data[1]);
            var season = data[2];
            var discountType = "None";

            if (data.Length > 3)
            {
                discountType = data[3];
            }
            var totalPrice = PriceCalculator.GetTotalPrice(pricePerDay, 
                numberOfDays, 
                Enum.Parse<Season>(season),
                Enum.Parse<Discount>(discountType));

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
