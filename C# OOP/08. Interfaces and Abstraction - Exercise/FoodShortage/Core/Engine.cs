namespace BorderControl.Core
{
    using System.Collections.Generic;
    using System.Linq;

    using FoodShortage.Models;
    using Contracts;
    using IO.Contracts;
    using Models;
    using Models.Contracts;
    internal class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private string[] inhabitantArguments;

        private ICollection<IBuyer> buyers;

        public Engine()
        {
            buyers = new HashSet<IBuyer>();
        }
        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            var linesCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                AddBuyer();
            }

            var name = reader.ReadLine();

            while (name != "End")
            {
                var currentBuyer = buyers
                    .FirstOrDefault(b => b.Name == name);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }

                name = reader.ReadLine();
            }

            var totalAmountOfFood = buyers.Select(b => b.Food).Sum();

            writer.WriteLine(totalAmountOfFood);
        }

        private void AddBuyer()
        {
            inhabitantArguments = reader.ReadLine()
                .Split(' ')
                .ToArray();

            var name = inhabitantArguments[0];
            var age = int.Parse(inhabitantArguments[1]);

            if (inhabitantArguments.Length == 4)
            {
                var id = inhabitantArguments[2];
                var birtdate = inhabitantArguments[3];

                IBuyer citizen = new Citizen(name, age, id, birtdate);
                buyers.Add(citizen);
            }
            else
            {
                var group = inhabitantArguments[2];

                IBuyer rebel = new Rebel(name, age, group);
                buyers.Add(rebel);
            }
        }
    }
}