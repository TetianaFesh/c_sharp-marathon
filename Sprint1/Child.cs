using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Child : Person
    {
        protected string childIDNumber;

        public Child(int _yearOfBirth, string _name, string _healthInfo, string _childIdNumber) : base(_yearOfBirth, _name, _healthInfo)
        {
            childIDNumber = _childIdNumber;
        }

        public override string ToString()
        {
            return $"{name} {childIDNumber}";
        }
    }
}
