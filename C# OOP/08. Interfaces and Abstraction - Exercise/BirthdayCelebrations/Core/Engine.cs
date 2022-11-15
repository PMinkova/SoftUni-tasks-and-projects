namespace BorderControl.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Contracts;
    using IO.Contracts;
    using Models;
    using Models.Contracts;
    internal class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private string[] inhabitantArguments;

        private List<IBirthable> inhabitants;

        public Engine()
        {
            this.inhabitants = new List<IBirthable>();
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
                inhabitantArguments = input
                    .Split(' ')
                    .ToArray();

                if (input.StartsWith("Pet"))
                {
                    AddPet();
                }
                else if (input.StartsWith("Citizen"))
                {
                    AddCitizen();
                }

                input = reader.ReadLine();
            }

            var year = reader.ReadLine();

            var birthdates = GetBirthdatesInParticularYear(year);

            PrintBirtdates(birthdates);
        }

        private void PrintBirtdates(IEnumerable<string> birthdates)
        {
            writer.WriteLine(string.Join(Environment.NewLine, birthdates));
        }

        private IEnumerable<string> GetBirthdatesInParticularYear(string year)
        {
            var birthdates = inhabitants
                .Where(x => x.Birthdate.EndsWith(year))
                .Select(x => x.Birthdate);
            return birthdates;
        }

        private void AddPet()
        {
            var name = inhabitantArguments[1];
            var birthDate = inhabitantArguments[2];

            IBirthable pet = new Pet(name, birthDate);
            inhabitants.Add(pet);
        }

        private void AddCitizen()
        {
            var name = inhabitantArguments[1];
            var age = int.Parse(inhabitantArguments[2]);
            var id = inhabitantArguments[3];
            var birthdate = inhabitantArguments[4];

            IBirthable citizen = new Citizen(name, age, id, birthdate);
            inhabitants.Add(citizen);
        }
    }
}
