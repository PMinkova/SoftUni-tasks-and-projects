using System.Reflection.Metadata;
using System.Text;

namespace P08_CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement)
        : this(model, power)
        {
            this.Discplacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
        : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }


        public string Model { get; set; }

        public int Power { get; set; }

        public int? Discplacement { get; set; } // nullable int

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string dispString = this.Discplacement.HasValue ? this.Discplacement.ToString() : "n/a";
            string effStr = string.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;
            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {dispString}")
                .Append($"    Efficiency: {effStr}");

            return sb.ToString().TrimEnd();
        }
    }
}
