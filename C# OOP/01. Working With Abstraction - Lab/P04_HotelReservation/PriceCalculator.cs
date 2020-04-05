namespace P04_HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal GetTotalPrice(decimal pricePerday, int numberOfDays, Season season, Discount discountType)
        {
            var priceMultiplier = (int) season;
            var discountMultiplier = (decimal) discountType / 100;
            decimal price = pricePerday * (decimal) numberOfDays * priceMultiplier;
            decimal discount = price * discountMultiplier;
            decimal totalPrice = price - discount;

            return totalPrice;
        }
    }

    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3,
    }

    public enum Discount
    {
        None = 0,
        SecondVisit = 10,
        VIP = 20,
    }
}
