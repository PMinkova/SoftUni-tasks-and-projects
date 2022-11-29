namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private const string Model = "VolksWagen";
        private const string Make = "Polo";

        private const double FuelConsumption = 3;
        private const double FuelCapacity = 50;


        [Test]
        public void ConstructorShouldInitializeDataProperly()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);

            Assert.AreEqual(Model, car.Model);
            Assert.AreEqual(Make, car.Make);
            Assert.AreEqual(FuelConsumption, car.FuelConsumption);
            Assert.AreEqual(FuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void ConstructorShouldSetInitialFuelAmountToZero()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);

            var expectedFuelAmount = 0;
            var actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [TestCase("")]
        [TestCase(null)]
        public void MakeSetterShouldThrowAnExceptionWhenValueIsNullOrEmpty(string carMake)
        {
            Assert.Throws<ArgumentException>(() => 
                new Car(carMake, Model, FuelConsumption, FuelCapacity));
        }

        [TestCase("")]
        [TestCase(null)]
        public void ModelSetterShouldThrowAnExceptionWhenValueIsNullOrEmpty(string carModel)
        {
            Assert.Throws<ArgumentException>(() =>
                new Car(Make, carModel, FuelConsumption, FuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FuelConsumptionSetterShouldThrowAnExceptionWhenValueIsZeroOrNegative(double carFuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => 
                new Car(Make, Model, carFuelConsumption, FuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FuelCapacitySetterShouldThrowAnExceptionWhenValueIsZeroOrNegative(double carFuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
                new Car(Make, Model, FuelConsumption, carFuelCapacity));
        }

        [TestCase(1)]
        [TestCase(49)]
        [TestCase(50)]
        public void RefuelShouldWorkProperlyWithPositiveFuelAmountAndEnoughFuelCapacity(double fuelToRefuel)
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);
            car.Refuel(fuelToRefuel);

            var expectedFuelAmount = fuelToRefuel;
            var actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void RefuelShouldReturnFuelAmountEqualToFuelCapacityWhenOverFlows()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);
            var fuelToRefuel = 60;

            car.Refuel(fuelToRefuel);

            var expectedFuelAmount = FuelCapacity;
            var actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [TestCase(0)]
        [TestCase(-10.5)]
        public void RefuelShouldThrowAnExceptionWithZeroOrNegativeFuelToRefuel(double fuelToRefuel)
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }

        [Test]
        public void DriveShouldReduceFuelAmountWhenIsEnough()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);

            var fuelTorefuel = 50;
            var distance = 500.0;
            var neededFuel = distance / 100 * FuelConsumption;

            car.Refuel(fuelTorefuel);
            car.Drive(distance);

            var expectedFuelAmount = fuelTorefuel - neededFuel;

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [Test]
        public void DriveShouldThrowAnExceptionWhenFuelAmountIsNotEnough()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);
            var distance = 500.00;

            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }

        [Test]
        public void TestRefuelWithZero()
        {
            var car = new Car(Make, Model, FuelConsumption, FuelCapacity);

            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(0);
            });
        }
    }
}