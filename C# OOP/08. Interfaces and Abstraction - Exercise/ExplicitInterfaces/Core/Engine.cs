namespace ExplicitInterfaces.Core
{
    using System.Collections.Generic;
    using System.Linq;

    using ExplicitInterfaces.IO.Contracts;
    using ExplicitInterfaces.Models;
    using ExplicitInterfaces.Models.Contracts;
    using Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICollection<Citizen> citizens;

        public Engine()
        {
            this.citizens = new HashSet<Citizen>();
        }
        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            var input = reader.ReadLine();

            while (input != "End")
            {
                var inputArguments = input
                    .Split(' ')
                    .ToArray();

                var name = inputArguments[0];
                var country = inputArguments[1];
                var age = int.Parse(inputArguments[2]);

                var citizen = new Citizen(name, country, age);

                citizens.Add(citizen);

                input = reader.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                writer.WriteLine(((IPerson)citizen).GetName());
                writer.WriteLine(citizen.GetName());
            }
        }
    }
}