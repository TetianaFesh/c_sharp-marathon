using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint5.Level1.Task3
{
    class MyProgram
    {
        public static void SearchKeys(Dictionary<string, string> persons)
        {
            foreach (string с in persons.Keys)
            {
                Console.WriteLine(с);
            }
        }

        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (string с in persons.Values)
            {
                Console.WriteLine(с);
            }
        }

        public static void SearchAdmin(Dictionary<string, string> persons)
        {
            foreach (var p in persons)
            {
                if (p.Value == "Admin")
                    Console.WriteLine(p.Key + " " + p.Value);
            }
        }

        //static void Main()
        //{
        //    Dictionary<string, string> persons = new Dictionary<string, string>();
        //    {
        //        persons.Add("id11111", "Admin");
        //        persons.Add("id12345", "User1");
        //        persons.Add("id98765", "User2");
        //        persons.Add("id56743", "User3");
        //        persons.Add("id73920", "User4");
        //    }
        //    MyProgram.SearchKeys(persons);
        //    MyProgram.SearchValues(persons);
        //    MyProgram.SearchAdmin(persons);
        //}
    }
}
