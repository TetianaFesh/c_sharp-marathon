using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Program
    {
        public static void Main()
        {
            Child c = new Child("12345", "Tetiana");
            Adult a = new Adult("54321", "Dmytro");
            string str = c.ToString();
            Console.WriteLine(str);
            str = a.ToString();
            Console.WriteLine(str);
        }
    }
}
