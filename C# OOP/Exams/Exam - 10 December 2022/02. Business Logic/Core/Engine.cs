namespace ChristmasPastryShop.Core
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

                    if (input[0] == "AddBooth")
                    {
                        var capacity = int.Parse(input[1]);

                        result = controller.AddBooth(capacity);
                    }
                    else if (input[0] == "AddDelicacy")
                    {
                        var boothId = int.Parse(input[1]);
                        var delicacyTypeName = input[2];
                        var delicacyName = input[3];

                        result = controller.AddDelicacy(boothId, delicacyTypeName, delicacyName);
                    }
                    else if (input[0] == "AddCocktail")
                    {
                        var boothId = int.Parse(input[1]);
                        var coctailTypeName = input[2];
                        var cocktailName = input[3];
                        var size = input[4];

                        result = controller.AddCocktail(boothId, coctailTypeName, cocktailName, size);
                    }
                    else if (input[0] == "ReserveBooth")
                    {
                        var countOfPeople = int.Parse(input[1]);

                        result = controller.ReserveBooth(countOfPeople);
                    }
                    else if (input[0] == "TryOrder")
                    {
                        var bootId = int.Parse(input[1]);
                        var order = input[2];

                        result = controller.TryOrder(bootId, order);
                    }
                    else if (input[0] == "LeaveBooth")
                    {
                        var boothId = int.Parse(input[1]);

                        result = controller.LeaveBooth(boothId);
                    }
                    else if (input[0] == "BoothReport")
                    {
                        var boothId = int.Parse(input[1]);

                        result = controller.BoothReport(boothId);
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
