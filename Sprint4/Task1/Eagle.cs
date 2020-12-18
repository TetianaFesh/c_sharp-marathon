using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public class Eagle : IAnimal, IFlyable
    {
        public int MaxHeight;
        public int LifeDuration;
        public void ShowInfo()
        {
            Console.WriteLine("I am a {0} and I live approximately {1} years.", this.GetType().Name, LifeDuration);
        }
        public void Fly()
        {
            Console.WriteLine("I can fly at {0} meters height!", MaxHeight);
        }
    }
}
