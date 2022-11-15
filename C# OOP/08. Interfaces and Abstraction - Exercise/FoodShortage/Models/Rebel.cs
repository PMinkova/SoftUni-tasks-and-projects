namespace FoodShortage.Models
{
    using BorderControl.Models.Contracts;
    public class Rebel : IBuyer
    {
        private const int FoodIncreaser = 5;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; }

        public int Age { get; }

        public string Group{ get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += FoodIncreaser;
        }
    }
}
