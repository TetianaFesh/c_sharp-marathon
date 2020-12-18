using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint5.Level2.Task3
{
    class task3
    {
        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {
            Lookup<string, string> result = (Lookup<string, string>)phonesToNames.ToLookup(t => t.Value ?? "", t => t.Key);
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            foreach (var value in result)
            {
                List<string> list = new List<string>();
                foreach (var v in value)
                {  
                    list.Add(v);
                }
                dictionary.Add(value.Key, list);
            }
            return dictionary;
        }         
    }
}
