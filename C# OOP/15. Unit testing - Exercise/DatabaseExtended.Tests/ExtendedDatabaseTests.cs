namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Person pesho;
        private Person sasho;
        private Person gosho;

        private Person[] persons;

        [SetUp]
        public void SetUp()
        {
            pesho = new Person(123, "Pesho");
            sasho = new Person(123456, "Sasho");
            gosho = new Person(54321, "Gosho");

            persons = new Person[] {pesho, sasho, gosho};
        }

        [Test]
        public void CountShouldReturnCorrectCount()
        {
            var database = new Database(persons);

            var expectedCount = database.Count;
            var actualCount = persons.Length;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionWhenAddingMoreThan16People()
        {
            var arr = new Person[18];

            Assert.Throws<ArgumentException>(() => new Database(arr));
        }

        [Test]
        public void AddShouldAddValidPerson()
        {
            var database = new Database();

            database.Add(pesho);
            database.Add(gosho);

            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void AddShouldThrowAnExceptionWhenCapacityReached()
        {
            var database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, $"Name{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(pesho));
        }

        [Test]
        public void AddShouldThrowAnExceptionWhenAddingPersonWithExistingName()
        {
            var database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(12, "Pesho")));
        }

        [Test]
        public void AddShouldThrowAnExceptionWhenAddingPersonWithExistingId()
        {
            var database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(123, "Mariya")));
        }

        [Test]
        public void RemoveShouldRemovePersonsCorrectly()
        {
            var database = new Database(persons);

            database.Remove();
            database.Remove();

            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void RemoveShouldThrowAnExceptionWhenDatabaseIsEmpty()
        {
            var database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FindByUsernameShouldReturnExistingPerson()
        {
            var database = new Database(persons);

            var expectedPerson = pesho;
            var actualPerson = database.FindByUsername("Pesho");
            
            Assert.AreEqual(expectedPerson, actualPerson);
        }

        [TestCase(null)]
        [TestCase("")]
        public void FindByUsernameThrowsAnExceptionWhenNameIsNullOrEmpty(string name)
        {
            var database = new Database(persons);

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name));
        }

        [Test]
        public void FindByUsernameShouldThrowAnExceptionWhenUsernameDoesNotExist()
        {
            var database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Toshko"));
        }

        [Test]
        public void FindByIdShouldReturnExistingPerson()
        {
            var database = new Database(persons);

            var expectedPerson = pesho;
            var actualPerson = database.FindById(123);

            Assert.AreEqual(expectedPerson, actualPerson);
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenSearchedIdIsNegativeNumber()
        {
            var database = new Database(persons);

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-10));
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenSearchedIdIsMissing()
        {
            var database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.FindById(1000));
        }
    }
}