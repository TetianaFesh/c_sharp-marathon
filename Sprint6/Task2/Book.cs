using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }
    }
}
