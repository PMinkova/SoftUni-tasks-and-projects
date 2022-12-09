namespace Heroes.Core
{
    using System;

    using Contracts;
    using IO;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new FileWriter();
            this.reader = new Reader();
            this.controller = new Controller();
        }

        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine().Split();

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    var result = string.Empty;

                    if (input[0] == "CreateHero")
                    {
                        var type = input[1];
                        var name = input[2];
                        var health = int.Parse(input[3]);
                        var armour = int.Parse(input[4]);

                        result = controller.CreateHero(type, name, health, armour);
                    }
                    else if (input[0] == "CreateWeapon")
                    {
                        var weaponType = input[1];
                        var name = input[2];
                        var durability = int.Parse(input[3]);

                        result = controller.CreateWeapon(weaponType, name, durability);
                    }
                    else if (input[0] == "AddWeaponToHero")
                    {
                        var weaponName = input[1];
                        var heroName = input[2];

                        result = controller.AddWeaponToHero(weaponName, heroName);
                    }
                    else if (input[0] == "StartBattle")
                    {
                        result = controller.StartBattle();
                    }
                    else if (input[0] == "HeroReport")
                    {
                        result = controller.HeroReport();
                    }

                    writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
