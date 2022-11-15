namespace BorderControl.Models
{
    using Contracts;
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private int FoodIncreaser = 10;
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthdate { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += FoodIncreaser;
        }
    }
}
