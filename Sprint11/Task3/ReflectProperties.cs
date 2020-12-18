using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sprint11.Task3
{
    class ReflectProperties
    {
        public class TestProperties
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            private string PhoneNumber { get; set; }
        }

        public static void WriteProperties()
        {
            Type myType = typeof(TestProperties);

            foreach (PropertyInfo prop in myType.GetProperties(BindingFlags.Instance |
                            BindingFlags.NonPublic |
                            BindingFlags.Public))
            {
                Console.WriteLine($"Property name: {prop.Name}");
                Console.WriteLine($"Property type: {prop.PropertyType}");
                Console.WriteLine($"Read-Write: {prop.CanWrite && prop.CanRead}");
                string access = "";
                if (prop.GetGetMethod(true).IsPublic) access = "Public";
                if (prop.GetGetMethod(true).IsFamilyOrAssembly) access = "Protected internal";
                if (prop.GetGetMethod(true).IsAssembly) access = "Internal";
                if (prop.GetGetMethod(true).IsFamily) access = "Protected";
                if (prop.GetGetMethod(true).IsPrivate) access = "Private";
               Console.WriteLine($"Accessibility level: {access}\n");
            }
        }
    }
}
