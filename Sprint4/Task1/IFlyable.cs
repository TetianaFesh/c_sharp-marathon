using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public interface IFlyable
    {
        int MaxHeight { get { return 0; } }
        void Fly()
        {
            Console.WriteLine("I can fly at {0} meters height!", MaxHeight);
        }
    }
}
