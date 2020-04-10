namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeMilliliters = 50;
        private const decimal CoffePrice = 3.5m;

        public Coffee(string name) : base(name, CoffePrice, CoffeMilliliters)
        {
        }

        public double Caffeine { get; set; }

    }
}
