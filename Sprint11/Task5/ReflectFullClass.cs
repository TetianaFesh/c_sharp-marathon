using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sprint11.Task5
{
    class ReflectFullClass
    {
        public static void WriteAllInClass(Type type)
        {
            Console.WriteLine($"Hello, {type.Name}!");

            Console.WriteLine($"There are {type.GetFields().Length} fields in {type.Name}");
            foreach (var field in type.GetFields())
                Console.Write($"{field.Name}, ");

            Console.WriteLine($"\nThere are {type.GetProperties().Length} properties in {type.Name}");
            foreach (var prop in type.GetProperties())
                Console.Write($"{prop.Name}, ");

            int count = 0;
            foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                if (!method.IsSpecialName) count++;

            Console.WriteLine($"\nThere are {count} methods in {type.Name}");
            foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                if(!method.IsSpecialName) Console.Write($"{method.Name}, ");

            Assembly assembly = type.Assembly;
            count = 0;
            foreach (var asmbl in assembly.GetTypes()) 
            {
                    if (asmbl.IsInterface) count++;
            }
            Console.WriteLine($"\nThere are {count} interfaces in {type.Name}");
            foreach (var asmbl in assembly.GetTypes())
                    if (asmbl.IsInterface)
                        Console.Write($"{asmbl.Name}, ");
            MemberInfo member = type;
            member.
        }
    }
}
