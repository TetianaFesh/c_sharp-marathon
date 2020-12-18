using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task2
{
    class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> book, Predicate<Book> predicate)
        {
            Library library = new Library(book);
            library.Filter = predicate;
            List<Book> result = new List<Book>();
            foreach (var item in library)
            {
                result.Add((Book)item);
            }
            return result;
        }

        //static void Main()
        //{
        //    List<Book> list = new List<Book>()
        //    {
        //        new Book("title1", "author1", 14),
        //        new Book("title2", "author2", 24),
        //        new Book("title3", "author3", 34),
        //        new Book("title4", "author4", 44)
        //    };
        //    Predicate<Book> predicate = (Book b) => b.PageCount > 24;
        //    List<Book> result = GetFiltered(list, predicate);
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item.Title + " " + item.Author + " " + item.PageCount);
        //    }
        //}
    }
}
