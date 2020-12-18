using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint7.Task6
{
    public class Student
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string GroupName { get; set; }

        public Student(string n, double r, string g)
        {
            Name = n;
            Rating = r;
            GroupName = g;
        }
    }
}
