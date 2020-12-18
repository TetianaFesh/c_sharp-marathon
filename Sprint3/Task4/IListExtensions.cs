using System;
using System.Collections.Generic;
using System.Text;
using Sprint3.Task5;

namespace Sprint3.Task4
{
    public static class IListExtensions
    {
        public static void IncreaseWith(this List<int> list, int increaseValue)
        {
            for (int  i = 0; i < list.Count; i++)
            {
                list[i] += increaseValue;
            }
        }

    }

    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this List<int> list)
        {
            string str = "[";
            for( int i = 0; i < list.Count - 1; i++)
            {
                str =  str + list[i] + ", ";
            }
            str = str + list[list.Count-1];
            str += "]";
            return str;
        }
    }
    
}
