using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint5.Level3
{
    class Student
    {
        public int Id { get; }
        public string Name { get; }
        public Student(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

        public static HashSet<Student> GetCommonStudents(List<Student> list1, List<Student> list2)
        {
            HashSet<Student> result1 = new HashSet<Student>(list1);
            HashSet<Student> result2 = new HashSet<Student>(list2);
            HashSet<Student> exept1 = new HashSet<Student>(list1);
            HashSet<Student> exept2 = new HashSet<Student>(list2);
            exept1.ExceptWith(new HashSet<Student>(list2));
            exept2.ExceptWith(new HashSet<Student>(list1));
            result1.UnionWith(result2);
            result1.ExceptWith(exept1);
            result1.ExceptWith(exept2);
            return result1;
        }

        public override int GetHashCode()
        {
            if (Name == null)
                return 13;
            else 
                return Name.Length * 13 ;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(student.Name))
                return true;
            return Name.Equals(student.Name) && Id == student.Id;
        }

        public static void Print(HashSet<Student> result)
        {
            foreach (var r in result)
            {
                Console.WriteLine(r.Id + " " + r.Name);
            }
        }

        static void Main()
        {
            List<Student> list1 = new List<Student>();
            list1.Add(new Student(1, "Ivan"));
            list1.Add(new Student(2, "Petro"));
            list1.Add(new Student(3, "Stepan"));
            List<Student> list2 = new List<Student>();
            list2.Add(new Student(1, "Ivan"));
            list2.Add(new Student(3, "Stepan"));
            list2.Add(new Student(4, "Andriy"));
            HashSet<Student> result = Student.GetCommonStudents(list1, list2);
            Console.WriteLine("\nRESULT\n");
            Student.Print(result);
        }
    }
}
