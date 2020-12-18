using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2.Task2
{
    public class Lory : Car
    {
        private double loadCapacity;

        public Lory(string _mark, int _prodYear, double _loadCapacity) : base(_mark, _prodYear)
        {
            loadCapacity = _loadCapacity;
        }

        public new void ShowInfo()
        {
            Console.WriteLine("Mark: {0},\nProduced in {1}\nThe load capacity is {2}", mark, prodYear, loadCapacity);
        }
    }
}
