namespace Restaurant
{
    public class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.Caloeries = calories;
        }

        public double Caloeries { get; set; }
    }
}
