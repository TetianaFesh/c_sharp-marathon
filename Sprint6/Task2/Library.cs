using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task2
{
    public class Library
    {
        public IEnumerable<Book> Books { get; }
        public Predicate<Book> Filter { get; set; }
        public Library(IEnumerable<Book> books)
        {
            Books = books;
            Filter = (Book obj) => true;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new MyEnumerator(Books, Filter);    
        }
    }
}
