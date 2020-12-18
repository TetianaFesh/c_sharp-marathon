using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint5.Level2.Task1
{
    class MyUtils
    {
        public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> diction)
        {
            bool result = true;
            foreach (string l in list)
            {
                result = diction.Values.Any(d => d == l);
                if (!result)
                    return false;
            }
            foreach (string value in diction.Values)
            {
                result = list.Any(d => d == value);
                if (!result)
                    return false;
            }
            return result;
        }

        //static void Main()
        //{
        //    List<string> list = new List<string> {"aa", "bb", "cc"};
        //    Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //    dictionary.Add("1", "cc");
        //    dictionary.Add("2", "bb");
        //    dictionary.Add("3", "cc");
        //    dictionary.Add("4", "aa");
        //    dictionary.Add("5", "cc");
        //    bool result = MyUtils.ListDictionaryCompare(list, dictionary);
        //    Console.WriteLine(result);
        //}
    }
}
