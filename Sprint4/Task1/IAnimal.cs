using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task1
{
    public interface IAnimal
    {
        public int LifeDuration { get { return 0; } }
        void Voice()
        {
            Console.WriteLine("No voice!");
        }
        void ShowInfo()
        {
            Console.WriteLine("I am a {0} and I live approximately {1} years.", this.GetType(), LifeDuration);
        }
    }
}
