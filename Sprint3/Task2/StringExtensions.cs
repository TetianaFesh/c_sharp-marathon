using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint3.Task2
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            char[] delemitersChar = { ' ', ',', '.', ':', '-', '!', '?', 
                                      '(', ')', '{', '}'};
            string[] str1 = str.Split(delemitersChar, StringSplitOptions.RemoveEmptyEntries);
            return str1.Length;
        }
    }
}
