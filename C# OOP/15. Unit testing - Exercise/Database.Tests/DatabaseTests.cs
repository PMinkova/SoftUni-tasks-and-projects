namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private int[] array;
        private int[] bigArray;
        private int[] limitArray;

        [SetUp]
        public void SetUp()
        {
            array = Enumerable.Range(1, 5).ToArray();
            limitArray = Enumerable.Range(1, 16).ToArray();
            bigArray = Enumerable.Range(1, 17).ToArray();
        }

        [Test]
        public void ConstructorShouldInitializeArrayWithCorrectCount()
        {
            var database = new Database(array);

            int expectedCount = array.Length;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenInputDataIsAbove16Count()
        {
            Assert.Throws<InvalidOperationException>(() => new Database(bigArray),
                "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void FetchShouldReturnCollectionWithElementsInTheDatabase()
        {
            var database = new Database(array);

            var expectedArray = array;
            var actualArray = database.Fetch();

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void AddingElementsShouldIncreaseCount()
        {
            var database = new Database();

            for (int i = 1; i <= 5; i++)
            {
                database.Add(i);
            }

            var expectedCount = 5;
            var actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddingElementsShouldAddThemToTheDataCollection()
        {
            var database = new Database();

            for (int i = 1; i <= 5; i++)
            {
                database.Add(i);
            }

            var expectedData = array;
            var actualData = database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void AddingMoreThen16ElementsShouldThrowAnException()
        {
            var db = new Database(limitArray);

            Assert.Throws<InvalidOperationException>(() =>
                db.Add(17), "Array's capacity must be exactly 16 integers");
        }

        [Test]
        public void RemoveShouldDecreaseCountByOne()
        {
            var database = new Database(array);
            database.Remove();
            Assert.True(database.Count == 4);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenDatabaseIsEmpty()
        {
            var database = new Database();

            Assert.Throws<InvalidOperationException>(() =>
                database.Remove(), "The collection is empty!");
        }

        [Test]
        public void RemoveShouldRemoveActuallyElementsFromTheDatabase()
        {
            Database database = new Database(array);

            database.Remove();
            database.Remove();

            var expectedData = new int[] { 1, 2, 3 };
            var actualData = database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}
