using System;

namespace Sprint2
{
    class Employee
    {
        internal string name;
        private DateTime hiringDate;

        public Employee(string _name, DateTime _hiringDate)
        {
            name = _name;
            hiringDate = _hiringDate;
        }

        public int Experience()
        {
            int year = DateTime.Now.Year - hiringDate.Year;
            if (hiringDate.Month > DateTime.Now.Month && year != 0)
            {
                year -= 1;
            }
            else if (hiringDate.Day > DateTime.Now.Day && hiringDate.Month > DateTime.Now.Month && year != 0)
            {
                year -= 1;
            }
            return year;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} has {1} years of experience", name, Experience());
        }
    }
}
