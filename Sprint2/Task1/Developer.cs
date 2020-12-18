using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2
{
    class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string _name, DateTime _hiringDate, string _programingLanguage) : base(_name, _hiringDate)
        {
            programmingLanguage = _programingLanguage;
        }

        public new void ShowInfo()
        {
            Console.WriteLine("{0} has {1} years of experience.\n{0} is {2} programmer", name, Experience(), programmingLanguage);
        }
    }
}
