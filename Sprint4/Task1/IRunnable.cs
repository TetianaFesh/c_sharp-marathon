using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public interface IRunnable
    {
        public int MaxSpeed { get { return 0; } }
        public void Run()
        {
            Console.WriteLine("I can run up to {0} kilometers per hour!", MaxSpeed);
        }
    }
}
