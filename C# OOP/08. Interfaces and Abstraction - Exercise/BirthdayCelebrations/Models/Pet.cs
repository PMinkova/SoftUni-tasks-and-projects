namespace BorderControl.Models
{
    using Contracts;
    public class Pet : IName, IBirthable
    {
        public Pet(string name, string birtdate)
        {
            this.Name = name;
            this.Birthdate = birtdate;
        }
        public string Name { get; }

        public string Birthdate { get; }
    }
}