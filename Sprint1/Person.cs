using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Person
    {
        
        private int yearOfBirth;
        private string healthInfo;
        protected string name;
        public Person(int _yearOfBirth, string _name, string _healthInfo)
        {
            yearOfBirth = _yearOfBirth;
            name = _name;
            healthInfo = _healthInfo;
        }

        public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
    }
}
