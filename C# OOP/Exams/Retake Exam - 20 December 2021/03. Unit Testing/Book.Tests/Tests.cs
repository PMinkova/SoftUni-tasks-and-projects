namespace Book.Tests
{
    using System;
    using NUnit.Framework;

    public class Tests
    {

        [Test]
        public void ConstructorShouldSetBookNameProperly()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            var expectedBookName = "Harry Potter";
            var actualBookName = book.BookName;

            Assert.AreEqual(expectedBookName, actualBookName);
        }

        [TestCase(null)]
        [TestCase("")]
        public void BookNameSetterShouldThrowAnExceptionWhenIsNullOrEmpty(string bookName)
        {
            Assert.Throws<ArgumentException>(() => new Book(bookName, "J.K.Rowling"));
        }

        [Test]
        public void ConstructorShouldInitializeAuthorProperly()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            var expectedAuthor = "J.K.Rowling";
            var actualAuthor = book.Author;

            Assert.AreEqual(expectedAuthor, actualAuthor);
        }

        [TestCase(null)]
        [TestCase("")]
        public void AuthorSetterShouldThrowAnExceptionWhenIsNullOrEmpty(string author)
        {
            Assert.Throws<ArgumentException>(() => new Book("Harry Potter", author));
        }

        [Test]

        public void FootnoteCountShouldReturnZeroWhenCollectionIsEmpty()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");
            Assert.AreEqual(0, book.FootnoteCount);

            var expectedCount = 0;
            var actualCount = book.FootnoteCount;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddFootnoteShouldIncreaseFootnoteCount()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            book.AddFootnote(1, "Some text");
            book.AddFootnote(2, "Another text");
        }

        [Test]
        public void AddFootnoteShouldThrowAnExceptionForExistingNumber()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            book.AddFootnote(1, "Some text");

            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(1, "Text"));
        }

        [Test]
        public void FindFootNoteShouldReturnCorrectFootnote()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");
            book.AddFootnote(1, "Text");

            var expected = $"Footnote #{1}: {"Text"}";
            var actual = book.FindFootnote(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindFootnoteShouldThrowAnExceptionForNonExistingFootnote()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");
            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(2));
        }

        [Test]
        public void AlterFootnoteChangesTheFootnoteText()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            book.AddFootnote(1, "Text");
            book.AlterFootnote(1, "Another text");

            var expected = "Footnote #1: Another text";
            var actual = book.FindFootnote(1);


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AlterFootnoteThrowsAnExceptionForNonExistingFootNote()
        {
            var book = new Book("Harry Potter", "J.K.Rowling");

            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(2, "Bar"));
        }

    }
}