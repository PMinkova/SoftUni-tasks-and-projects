namespace RepairShop.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        public class RepairsShopTests
        {

            [Test]
            public void ConstructorShouldInitializeCarsCollectionProperly()
            {
                var garage = new Garage("Toto", 5);

                Assert.IsNotNull(garage.CarsInGarage);
            }

            [Test]
            public void ConstructorShouldInitializeGarageNameProperly()
            {
                var garage = new Garage("Toto", 5);

                Assert.AreEqual("Toto", garage.Name);
            }

            [TestCase(null)]
            [TestCase("")]
            public void ConstructorShouldThrowAnExceptionWhenNameIsNullOrEmpty(string name)
            {
                Assert.Throws<ArgumentNullException>(() => new Garage(name, 5));
            }

            [Test]
            public void ConstructorShouldInitializeMechanicsAvailableProperly()
            {
                var garage = new Garage("Toto", 5);

                Assert.AreEqual(5, garage.MechanicsAvailable);
            }

            [TestCase(0)]
            [TestCase(-1)]
            public void ConstructorShouldThrowAnExceptionWithZeroOrNegativeMechanicsAvailable(int mechanicsAvailable)
            {
                Assert.Throws<ArgumentException>(() => new Garage("Toto", mechanicsAvailable));
            }

            [Test]
            public void AddCarShouldIncreaseCarsInTheGarage()
            {
                var garage = new Garage("Toto", 5);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                Assert.AreEqual(1, garage.CarsInGarage);
            }

            [Test]
            public void ConstructorShouldThrowAnExceptionForNonAvailableMechanics()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.AddCar(new Car("Nissan", 6)));
            }

            [Test]
            public void FixCarShouldSetNumberOfIssuesToZero()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                var fixedCar = garage.FixCar("BMW");

                Assert.AreEqual(0, fixedCar.NumberOfIssues);
            }

            [Test]
            public void FixCarShouldThrowAnExceptionForNonExistingCar()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.FixCar("Audi"));
            }

            [Test]
            public void RemoveFixedCarShouldDecreaseFixedCars()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);
                var fixedCar = garage.FixCar("BMW");

                Assert.AreEqual(1, garage.RemoveFixedCar());
            }

            [Test]
            public void RemoveFixedCarShouldThrowAnExceptionWhenNoFixedCarsAreAvailable()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.RemoveFixedCar());
            }

            [Test]
            public void ReportShouldReturnAListWithAllUnfixedCarsAsString()
            {
                var garage = new Garage("Toto", 1);
                var car = new Car("BMW", 3);

                garage.AddCar(car);

                var expectedResult = "There are 1 which are not fixed: BMW.";
                var actualResult = garage.Report();

                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}