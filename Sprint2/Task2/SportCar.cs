using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2.Task2
{
    public class SportCar : Car
    {
        private int maxSpeed;

        public SportCar(string _mark, int _prodYear, int _maxSpeed) : base(_mark, _prodYear)
        {
            maxSpeed = _maxSpeed;
        }

        public new void ShowInfo()
        {
            Console.WriteLine("Mark: {0},\nProduced in {1}\nMaximum speed is {2}", mark, prodYear, maxSpeed);
        }
    }
}
