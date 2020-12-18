using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sprint11.Task4
{
    class ReflectorAssembly
    {
        class LargeBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        class Box
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        class SmallBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }

            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }

        public interface ILookingForBox
        {
            static void LookForBox(string str) { }
        }

        public interface IPackingBox
        {
            static void PackBox(string str) { }
        }

        public static void WriteAssemblies()
        {
            Assembly myAssemby = typeof(ReflectorAssembly).Assembly;
            foreach (var assembly in myAssemby.GetTypes()) {
                if (assembly.IsClass && assembly.Name != "Task" && assembly.Name != "Reflector")
                {
                    Console.WriteLine("Class: " + assembly.Name);
                    foreach (var methods in assembly.GetMethods())
                    {
                        if (methods.Name == "GetType") break;
                        else
                        {
                            Console.WriteLine("Method: " + methods.Name);
                            if (assembly.Name == "LargeBox")
                                methods.Invoke(null, new object[] { "large" });
                            if (assembly.Name == "Box")
                                methods.Invoke(null, new object[] { "middle" });
                            if (assembly.Name == "SmallBox")
                                methods.Invoke(null, new object[] { "small" });

                        }
                    }           
                }
                if (assembly.IsInterface)
                {
                    Console.WriteLine("Interface: " + assembly.Name);
                    foreach (var methods in assembly.GetMethods())
                    {
                        if (methods.Name == "GetType") break;
                        else
                        {
                            Console.WriteLine("Method: " + methods.Name);

                        }
                    }
                }
                
            }
        }
    }
}
