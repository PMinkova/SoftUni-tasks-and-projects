namespace MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using IO.Contracts;
    using Models;
    using Models.Contracts;
    using Models.Enums;
    public class Engine : IEngine
    { 
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICollection<ISoldier> soldiers;

        private string[] commandArguments;

        public Engine()
        {
            this.soldiers = new HashSet<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            this.CreateSoldiers();
            this.PrintSoldiers();
        }

        private void CreateSoldiers()
        {
            string command = reader.ReadLine();

            while (command != "End")
            {
                commandArguments = command
                    .Split(' ')
                    .ToArray();

                var soldierType = commandArguments[0];
                var id = int.Parse(commandArguments[1]);
                var firstName = commandArguments[2];
                var lastName = commandArguments[3];

                if (soldierType == "Private")
                {
                    var salary = decimal.Parse(commandArguments[4]);

                    AddPrivate(id, firstName, lastName, salary);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    var salary = decimal.Parse(commandArguments[4]);

                    AddLieutenantGeneral(id, firstName, lastName, salary);
                }
                else if (soldierType == "Engineer")
                {
                    var salary = decimal.Parse(commandArguments[4]);
                    var corpsText = commandArguments[5];

                    AddEngineer(corpsText, id, firstName, lastName, salary);
                }
                else if (soldierType == "Commando")
                {
                    var salary = decimal.Parse(commandArguments[4]);
                    var corpsText = commandArguments[5];

                    AddCommando(corpsText, id, firstName, lastName, salary);
                }
                else if (soldierType == "Spy")
                {
                    var codeNumber = int.Parse(commandArguments[4]);

                    var soldier = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(soldier);
                }

                command = reader.ReadLine();
            }
        }

        private void AddCommando(string corpsText, int id, string firstName, string lastName, decimal salary)
        {
            var isCorpsValid = Enum.TryParse(corpsText, false, out Corps corps);

            if (isCorpsValid)
            {
                var missions = CreateMissions();

                var soldier = new Commando(id, firstName, lastName, salary, corps, missions);
                soldiers.Add(soldier);
            }
        }

        private ICollection<IMission> CreateMissions()
        {
            ICollection<IMission> missions = new HashSet<IMission>();

            var missionArguments = commandArguments.Skip(6).ToArray();

            for (int i = 0; i < missionArguments.Length; i += 2)
            {
                var missionCodeName = missionArguments[i];
                var missionState = missionArguments[i + 1];

                var isMissionStateValid = Enum.TryParse(missionState, false, out State state);

                if (isMissionStateValid)
                {
                    var currentMission = new Mission(missionCodeName, state);
                    missions.Add(currentMission);
                }
            }

            return missions;
        }

        private void AddEngineer(string corpsText, int id, string firstName, string lastName, decimal salary)
        {
            var isCorpsValid = Enum.TryParse(corpsText, false, out Corps corps);

            if (isCorpsValid)
            {
                var repairs = CreateRepairs();

                var soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
                soldiers.Add(soldier);
            }
        }

        private ICollection<IRepair> CreateRepairs()
        {
            ICollection<IRepair> repairs = new HashSet<IRepair>();

            var repairArguments = commandArguments.Skip(6).ToArray();

            for (int i = 0; i < repairArguments.Length; i += 2)
            {
                var repairPart = repairArguments[i];
                var repairHours = int.Parse(repairArguments[i + 1]);

                var currentRepair = new Repair(repairPart, repairHours);
                repairs.Add(currentRepair);
            }

            return repairs;
        }

        private void AddLieutenantGeneral(int id, string firstName, string lastName, decimal salary)
        {
            ICollection<IPrivate> privates = new HashSet<IPrivate>();

            foreach (var privateId in commandArguments.Skip(5))
            {
                var currentPrivate = (IPrivate)soldiers
                    .FirstOrDefault(s => s.Id == int.Parse(privateId));

                privates.Add(currentPrivate);
            }

            var soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
            soldiers.Add(soldier);
        }

        private void AddPrivate(int id, string firstName, string lastName, decimal salary)
        {
            var soldier = new Private(id, firstName, lastName, salary);
            soldiers.Add(soldier);
        }

        private void PrintSoldiers()
        {
            foreach (var soldier in soldiers)
            {
                writer.WriteLine(soldier.ToString());
            }
        }
    }
}