using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint5.Level2.Task2
{
    class task2
    {
        public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
        {
            Lookup<string, string> result = (Lookup<string, string>)phonesToNames.ToLookup(t => t.Value ?? "", t => t.Key ?? "");           
            return result;
        }
        //static void Main()
        //{
        //    Dictionary<string, string> phonesToNames = new Dictionary<string, string>();
        //    phonesToNames.Add("09919265784", "Tetiana");
        //    phonesToNames.Add("853769436", "Tetiana");
        //    phonesToNames.Add("39486729836", "Dmytro");
        //    phonesToNames.Add("1902587645", "Ivan");
        //    phonesToNames.Add("8725983t", null);
        //    phonesToNames.Add("89236593846", null);
        //    Lookup<string, string> result = task2.CreateNotebook(phonesToNames);
        //}
    }
}
