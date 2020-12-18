using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Adult : Person
    {
        private string passportNumber;
      
        public Adult(int _yearOfBirth, string _name, string _healthInfo, string _passoprtNumber) : base(_yearOfBirth, _name, _healthInfo)
        {
            passportNumber = _passoprtNumber;
        }
        public override string ToString()
        {
            return $"{name} {passportNumber}";
        }
    }
}
