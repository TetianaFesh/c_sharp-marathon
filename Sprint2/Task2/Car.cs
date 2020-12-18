using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2.Task2
{
    public abstract class Car
    {
        internal string mark;
        internal int prodYear;

        public Car(string _mark, int _prodYear)
        {
            mark = _mark;
            prodYear = _prodYear;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Mark: {0},\nProduced in {1}", mark, prodYear);
        }
    }
}
