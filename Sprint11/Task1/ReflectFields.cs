using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Sprint11.Task1
{
    class ReflectFields
    {
        public static string Name;
        public static int MeasureX;
        public static int MeasureY;
        public static int MeasureZ;

        public static void OutputFields()
        {
            Type myType = Type.GetType("Sprint11.Task1.ReflectFields", false, true);
            string type = "";
            foreach (FieldInfo field in myType.GetFields())
            {
                if (field.FieldType.Name == "Int32") type = "int";
                else type = field.FieldType.Name.ToLower();
                Console.WriteLine($"{field.Name} ({type}) = {field.GetValue(null)} ");
            }
        }

        
    }
}
