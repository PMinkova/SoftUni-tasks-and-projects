using System.Collections;
using System.Collections.Generic;
using System.Threading;
using P01_Library;

namespace IteratorsAndComparators
{
    public class Library
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
    }
}
