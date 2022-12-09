namespace BookigApp.Tests
{
    using System;

    using FrontDeskApp;
    using NUnit.Framework;

    public class Tests
    {
        private Room room;
        private Hotel hotel;

        [SetUp]
        public void Setup()
        {
            room = new Room(2, 100);
            hotel = new Hotel("Sunny day", 5);
        }

        [Test]
        public void ConstructorShouldInitializeRoomsCollectionProperly()
        {
            Assert.IsNotNull(hotel.Rooms);
        }


        [Test]
        public void ConstructorShouldInitializeBookingCollectionProperly()
        {
            Assert.IsNotNull(hotel.Bookings);
        }

        [Test]
        public void ConstructorShouldInitializeFullName()
        {
            Assert.AreEqual("Sunny day", hotel.FullName);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        public void ConstructorShouldThrowAnExceptionWhenFullNameIsNullOrWhiteSpace(string fullName)
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(fullName, 5));
        }

        [Test]
        public void ConstructorShouldInitializeCategory()
        {
            Assert.AreEqual(5, hotel.Category);
        }

        [TestCase(0)]
        [TestCase(6)]
        public void ConstructorShouldThrowAnExceptionWhenCategoryIsLessThenOneAndMoreThenFive(int category)
        {
            Assert.Throws<ArgumentException>(() => new Hotel("Sunny beach", category));
        }

        [Test]
        public void AddRoomShouldIncreaseRoomsCount()
        {
            hotel.AddRoom(room);
            Assert.AreEqual(1, hotel.Rooms.Count);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void BookRoomShouldThrowAnExceptionWithZeroOrLessAdults(int adults)
        {
            Assert.Throws<ArgumentException>(()
                => this.hotel.BookRoom(adults, 2, 3, 200));
        }

        [Test]
        public void BookRoomShouldThrowAnExceptionWithNegativeChildrenCount()
        {
            Assert.Throws<ArgumentException>(()
                => this.hotel.BookRoom(2, -1, 3, 200));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void BookRoomShouldThrowAnExceptionWithLessThenOneDuration(int duration)
        {
            Assert.Throws<ArgumentException>(()
                => this.hotel.BookRoom(2, 2, duration, 200));
        }

        [Test]
        public void BookRoomShouldIncreaseTurnOver()
        {
            this.hotel.AddRoom(room);
            this.hotel.BookRoom(2, 0, 5, 2000);

            Assert.AreEqual(500, this.hotel.Turnover);
        }

        [Test]
        public void BookRoomShouldIncreaseBookingCount()
        {
            this.hotel.AddRoom(room);
            this.hotel.BookRoom(2, 0, 5, 2000);

            Assert.AreEqual(1, this.hotel.Bookings.Count);
        }

        [Test]
        public void BookRoomShouldNotIncreaseBookingsCountWhenBadCapacityIsInsufficient()
        {
            this.hotel.AddRoom(room);
            this.hotel.BookRoom(3, 0, 5, 2000);

            Assert.AreEqual(0, this.hotel.Bookings.Count);
        }

        [Test]
        public void BookRoomShouldNotIncreaseBookingsCountWhenBudgetIsNotEnough()
        {
            this.hotel.AddRoom(room);
            this.hotel.BookRoom(3, 0, 5, 100);

            Assert.AreEqual(0, this.hotel.Bookings.Count);
            Assert.AreEqual(0, this.hotel.Turnover);
        }
    }
}