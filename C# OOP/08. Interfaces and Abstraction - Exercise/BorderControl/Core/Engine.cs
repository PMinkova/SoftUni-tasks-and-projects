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

        private List<IIdentifiable> inhabitants;

        public Engine()
        {
            this.inhabitants = new List<IIdentifiable>();
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
                var inhabitantArguments = input
                    .Split(' ')
                    .ToArray();

                if (inhabitantArguments.Length == 2)
                {
                    AddRobot(inhabitantArguments);
                }
                else
                {
                    AddCitizen(inhabitantArguments);
                }

                input = reader.ReadLine();
            }

            var invalidIds = GetInvalidIds();

            PrintInvalidIds(invalidIds);
        }

        private List<string> GetInvalidIds()
        {
            var invalidIdFraction = reader.ReadLine();

            var invalidIds = inhabitants
                .Where(i => i.Id.EndsWith(invalidIdFraction))
                .Select(i => i.Id)
                .ToList();
            return invalidIds;
        }

        private void PrintInvalidIds(List<string> invalidIds)
        {
            writer.WriteLine(String.Join(Environment.NewLine, invalidIds));
        }

        private void AddCitizen(string[] inhabitantArguments)
        {
            var name = inhabitantArguments[0];
            var age = int.Parse(inhabitantArguments[1]);
            var id = inhabitantArguments[2];

            IIdentifiable citizen = new Citizen(name, age, id);
            inhabitants.Add(citizen);
        }

        private void AddRobot(string[] inhabitantArguments)
        {
            var model = inhabitantArguments[0];
            var id = inhabitantArguments[1];

            IIdentifiable robot = new Robot(model, id);
            inhabitants.Add(robot);
        }
    }
}
