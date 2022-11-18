namespace Vehicles.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Exceptions;
    using Factories.Contracts;
    using IO.Contracts;
    using Models;
    using Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private IVehicleFactory vehicleFactory;

        private ICollection<IVehicle> vehicles;

        public Engine()
        {
            vehicles = new HashSet<IVehicle>();
        }
        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }
        public void Run()
        {
            this.vehicles.Add(BuildVehicleUsingFactory());
            this.vehicles.Add(BuildVehicleUsingFactory());
            this.vehicles.Add(BuildVehicleUsingFactory());

            var n = int.Parse(reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (InvalidVehicleTypeException ive)
                {
                    this.writer.WriteLine(ive.Message);
                }
                catch (ZeroOrNegativeNumberException zne)
                {
                    this.writer.WriteLine(zne.Message);
                }
                catch (ArgumentException ae)
                {
                    this.writer.WriteLine(ae.Message);
                }
            }

            PrintAllVehicles();
        }

        private void PrintAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }
        }

        private void ProcessCommand()
        {
            var commandArguments = this.reader.ReadLine()
                .Split(' ')
                .ToArray();

            var command = commandArguments[0];
            var vehicleType = commandArguments[1];

            var currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

            if (currentVehicle == null)
            {
                throw new InvalidVehicleTypeException();
            }

            if (command == "Drive")
            {
                var distance = double.Parse(commandArguments[2]);
                this.writer.WriteLine(currentVehicle.Drive(distance));
            }
            else if (command == "DriveEmpty")
            {
                var distance = double.Parse(commandArguments[2]);
                Bus bus = (Bus)currentVehicle;
                this.writer.WriteLine(bus.DriveEmpty(distance));

            }
            else if (command == "Refuel")
            {
                var liters = double.Parse(commandArguments[2]);
                currentVehicle.Refuel(liters);
            }
        }

        public IVehicle BuildVehicleUsingFactory()
        {
            var vehicleArguments = this.reader.ReadLine()
                .Split(' ')
                .ToArray();

            var vehicleType = vehicleArguments[0];
            var vehicleFuelQuantity = double.Parse(vehicleArguments[1]);
            var vehicleFuelConsumption = double.Parse(vehicleArguments[2]);
            var vehicleTankCapacity = double.Parse(vehicleArguments[3]);

            IVehicle vehicle = this.vehicleFactory
                .CreateVehicle(vehicleType, vehicleFuelQuantity, vehicleFuelConsumption, vehicleTankCapacity);

            return vehicle;
        }
    }
}