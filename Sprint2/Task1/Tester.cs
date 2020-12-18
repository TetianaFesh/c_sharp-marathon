using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2
{
    class Tester : Employee
    {
        private bool isAuthomation;

        public Tester(string _name, DateTime _hiringDate, bool _isAuthomation) : base(_name, _hiringDate)
        {
            isAuthomation = _isAuthomation;
        }

        public new void ShowInfo()
        {
            if (isAuthomation)
            {
                Console.WriteLine("{0} is authomated tester and has {1} year(s) of experience", name, Experience());
            }
            else
            {
                Console.WriteLine("{0} is manual tester and has {1} year(s) of experience", name, Experience());
            }
        }      
    }
}
