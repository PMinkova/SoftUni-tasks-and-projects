namespace Robots.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
           robot = new Robot("Petya", 20);
           robotManager = new RobotManager(5);
        }

        [Test]
        public void ConstructorShouldInitializeCapacityProperly()
        {
            Assert.AreEqual(5, this.robotManager.Capacity);
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionForNegativeCapacity()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-10));
        }

        [Test]
        public void CountShouldReturnZeroForEmptyRobotManager()
        {
            Assert.AreEqual(0, this.robotManager.Count);
        }

        [Test]
        public void AddShouldAddRobotsCorrectly()
        {
            this.robotManager.Add(this.robot);
            this.robotManager.Add(new Robot("Katya", 40));
            
            Assert.AreEqual(2, this.robotManager.Count);
        }

        [Test]
        public void AddRobotsShouldThrowAnExceptionWhenCapacityIsReached()
        {
            var manager = new RobotManager(2);

            manager.Add(new Robot("Toni", 25));
            manager.Add(new Robot("Katya", 40));

            Assert.Throws<InvalidOperationException>(() => manager.Add(robot));
        }

        [Test]
        public void AddShouldThrowAnExceptionForRobotsWithTheSameName()
        {
            this.robotManager.Add(new Robot("Toni", 25));

            Assert.Throws<InvalidOperationException>(() 
                => robotManager.Add(new Robot("Toni", 30)));
        }

        [Test]
        public void RemoveShouldWorkProperly()
        {
            this.robotManager.Add(new Robot("Toni", 25));
            this.robotManager.Remove("Toni");

            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void RemoveShouldThrowAnExceptionForNonExistingRobotName()
        {
            Assert.Throws<InvalidOperationException>(() => this.robotManager.Remove("Niki"));
        }

        [Test]
        public void WorkShouldReduceBattery()
        {
            robotManager.Add(this.robot);
            robotManager.Work("Petya", "Laundry", 15);

            Assert.AreEqual(5, this.robot.Battery);
        }

        [Test]
        public void WorkShouldThrowAnExceptionForNonExistingRobot()
        {
            this.robotManager.Add(this.robot);

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Work("Nadya", "Dishes", 10));
        }

        [Test]
        public void WorkShouldThrowAnExceptionForInsufficientBattery()
        {
            this.robotManager.Add(new Robot("Toni", 25));

            Assert.Throws<InvalidOperationException>(()
                => robotManager.Work("Toni", "Cleaning", 30));
        }

        [Test]
        public void ChargeShouldSetTheBatteryToMaxCharge()
        {
            this.robotManager.Add(robot);

            this.robotManager.Work("Petya", "Laundry", 15);
            this.robotManager.Charge("Petya");

            Assert.AreEqual(20, this.robot.Battery);
        }

        [Test]
        public void ChargeShouldThrowAnExceptionWhenRobotNotFound()
        {
            Assert.Throws<InvalidOperationException>(() 
                => this.robotManager.Charge("Ivan"));
        }
    }
}
