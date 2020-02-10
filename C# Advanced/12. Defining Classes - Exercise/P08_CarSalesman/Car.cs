using System;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Text;

namespace P08_CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, double weigth)
        : this(model, engine)
        {
            this.Weigth = weigth;
        }

        public Car(string model, Engine engine, string color)
        :this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight, string color)
        : this(model, engine)
        {
            this.Color = color;
            this.Weigth = weight;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }  

        public double? Weigth { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string weigthStr = this.Weigth.HasValue ? this.Weigth.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;

            sb.AppendLine($"{this.Model}:")
                .AppendLine($"  {this.Engine}")
                .AppendLine($"  Weight: {weigthStr}")
                .Append($"  Color: {colorStr}");

            return sb.ToString().TrimEnd();
        }
    }
}
