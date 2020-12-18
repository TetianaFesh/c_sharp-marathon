using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task2
{
    class MyEnumerator : IEnumerator<Book>
    {
        public List<Book> book { get; set; }
        int position = -1;
        public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
        {
            List<Book> list = (List<Book>)books;
            book = new List<Book>(list.FindAll(filter));
        }
        public Book Current => book[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position++;
            return position < book.Count;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
