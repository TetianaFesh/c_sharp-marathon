using System;
using System.Collections.Generic;
using System.Text;
namespace Sprint4.Task3
{
    public interface IDocument
    {
        public static string defaultText = "Lorem ipsum";
        public int Pages { get { return 0; } set { } }
        public string Name { get; set; }
        public void AddPages(int _pages)
        {
            Pages += _pages;
        }
         public void Rename(string _name)
        {
            Name = _name;
        }
    }
}
