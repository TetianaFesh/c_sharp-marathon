using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task2
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public void Voice()
        {
            Console.WriteLine("Woof");
        }
        
        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }
    }
}
