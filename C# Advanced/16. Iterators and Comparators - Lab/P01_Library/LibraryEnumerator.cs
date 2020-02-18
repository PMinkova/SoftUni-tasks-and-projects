using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using IteratorsAndComparators;


namespace P01_Library
{
    public class LibraryEnumerator : IEnumerator<Book>
    {
        private int currentIndex = -1;


        public LibraryEnumerator(List<Book> books)
        {
            this.Reset();
            this.Books = books;
        }
        public List<Book> Books { get; }

        public bool MoveNext()
        {
            this.currentIndex++;

            if (this.currentIndex >= this.Books.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset() => this.currentIndex = -1;

        public Book Current => this.Books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
        }
    }
}
