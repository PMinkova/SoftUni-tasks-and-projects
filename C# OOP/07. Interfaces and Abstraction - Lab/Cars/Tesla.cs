using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model,  string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        public string Model { get; }

        public string Color { get; }

        public int Battery { get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"{this.Color} {GetType().Name} {this.Model} with {this.Battery} Batteries")
                .AppendLine(Start())
                .AppendLine(Stop());

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
