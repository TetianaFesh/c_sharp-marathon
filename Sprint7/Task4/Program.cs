using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint7.Task4
{
    public class Program
    {
        public static string GetWord(string input, string seed)
        {
            string result = string.Empty;
            var _input = input.Split(" ").Where(x => x.Length > seed.Length).OrderByDescending(x => x.Length);
            if (_input.Count() == 0 || input.Length == 0)
            { 
                string[] res = seed.Split('a');
                if (res.Length == 0) return seed;
                else
                    return GerWordWithA(seed);
            }
            else
            { 
                if (_input.First().Contains('a'))
                {
                    return GerWordWithA(_input.First());

                }
                else return result;
            }
        }

        public static string GerWordWithA(string word)
        {
            string result = string.Empty;
            string[] res = word.Split('a');
            for (int i = 1; i < res.Length; i++)
            {
                result += 'a';
                result += res[i];
            }
            return result;
        }

        //static void Main()
        //{
        //    string str = GetWord("Hello my littеееle world My name is John", "Hello");
        //    Console.Write(str);
        //}
    }
}
