using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public class Cat : IAnimal, IRunnable
    {
        public int MaxSpeed;
        public int LifeDuration;
        public void ShowInfo()
        {
            Console.WriteLine("I am a {0} and I live approximately {1} years.", this.GetType().Name, LifeDuration);
        }
        public void Voice()
        {
            Console.WriteLine("Meow!");
        }

        public void Run()
        {
            Console.WriteLine("I can run up to {0} kilometers per hour!", MaxSpeed);
        }
    }
}
