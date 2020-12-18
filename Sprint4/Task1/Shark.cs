using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public class Shark : IAnimal, ISwimmable
    {
        readonly int LifeDuration;
        public void ShowInfo()
        {
            Console.WriteLine("I am a {0} and I live approximately {1} years.", this.GetType().Name, LifeDuration);
        }
    }
}
