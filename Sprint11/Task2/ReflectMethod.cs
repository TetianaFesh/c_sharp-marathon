using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Sprint11.Task2
{
    class ReflectMethod
    {
        public static class Methods
        {
            public static void Hello(string parameter)
            {
                Console.WriteLine($"Hello:parametr={parameter}");
            }

            public static void Welcome(string parameter)
            {
                Console.WriteLine($"Welcome:parametr={parameter}");
            }

            public static void Bye(string parameter)
            {
                Console.WriteLine($"Bye:parametr={parameter}");
            }
        }

        public static void InvokeMethod(string[] str)
        {
            Type myType = typeof(Methods);
            foreach (MethodInfo method in myType.GetMethods())
            {
                if (method.Name == "GetType") break;
                else 
                foreach (string s in str)
                    method.Invoke(null, new object[] { s});
            }
        }
    }
}
