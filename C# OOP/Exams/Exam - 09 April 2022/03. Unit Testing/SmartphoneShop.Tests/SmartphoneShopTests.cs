using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        private Shop shop;

        [SetUp]
        public void SetUp()
        {
            this.shop = new Shop(5);
        }

        [Test]
        public void ConstructorShouldSetCapacityProperly()
        {
            Assert.AreEqual(5, this.shop.Capacity);
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionForNegativeCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Shop(-2));
        }

        [Test]
        public void CountShouldReturnCorrectPhonesCount()
        {
            shop.Add(new Smartphone("Iphone", 90));
            shop.Add(new Smartphone("Motorola", 65));
            shop.Add(new Smartphone("Samsung", 95));

            Assert.AreEqual(3, shop.Count);
        }

        [Test]
        public void AddShouldAddPhonesToTheShopCorrectly()
        {
            var smartphone = new Smartphone("Iphone", 90);
            shop.Add(smartphone);

            Assert.AreEqual(1, shop.Count);
        }

        [Test]
        public void AddShouldThrowAnExceptionForExistingModels()
        {
            shop.Add(new Smartphone("Iphone", 90));
            shop.Add(new Smartphone("Motorola", 65));

            Assert.Throws<InvalidOperationException>(()
                => shop.Add(new Smartphone("Iphone", 45)));
        }

        [Test]
        public void AddShouldThrowAnExceptionWhenCapacityIsReached()
        {
            var phoneShop = new Shop(2);

            var iphone = new Smartphone("Iphone", 90);
            var motorola = new Smartphone("Motorola", 65);

            phoneShop.Add(iphone);
            phoneShop.Add(motorola);

            Assert.Throws<InvalidOperationException>(()
                => phoneShop.Add(new Smartphone("Huawei", 100)));
        }

        [Test]
        public void RemoveShouldReduceCount()
        {
            var iphone = new Smartphone("Iphone", 90);
            var motorola = new Smartphone("Motorola", 65);

            shop.Add(iphone);
            shop.Add(motorola);

            shop.Remove("Motorola");

            Assert.AreEqual(1, shop.Count);
        }

        [Test]
        public void RemoveShouldThrowAnExceptionForNonExistingModel()
        {
            var iphone = new Smartphone("Iphone", 90);
            var motorola = new Smartphone("Motorola", 65);

            shop.Add(iphone);
            shop.Add(motorola);

            Assert.Throws<InvalidOperationException>(()
                => shop.Remove("Samsung"));
        }

        [Test]
        public void TestPhoneShouldReduceTheBattery()
        {
            var iphone = new Smartphone("Iphone", 90);

            shop.Add(iphone);
            shop.TestPhone("Iphone", 20);

            Assert.AreEqual(70, iphone.CurrentBateryCharge);
        }

        [Test]
        public void TestPhoneShouldThrowAnExceptionForNonExistingModel()
        {
            var iphone = new Smartphone("Iphone", 90);

            shop.Add(iphone);

            Assert.Throws<InvalidOperationException>(()
                => shop.TestPhone("Motorola", 30));
        }

        [Test]
        public void TestPhoneShouldThrowAnExceptionForLowBattery()
        {
            var iphone = new Smartphone("Iphone", 20);

            shop.Add(iphone);

            Assert.Throws<InvalidOperationException>(()
                => shop.TestPhone("Iphone", 30));
        }

        [Test]
        public void ChargeShouldSetTheBatteryToMaximumBatteryCharge()
        {
            var iphone = new Smartphone("Iphone", 100);

            shop.Add(iphone);
            shop.TestPhone("Iphone", 50);
            shop.ChargePhone("Iphone");

            Assert.AreEqual(iphone.MaximumBatteryCharge, iphone.CurrentBateryCharge);
        }
    }
}