using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task1
{
    class Parrot : Bird, IKryaking, IBasking
    {
        public void Bask()
        {
            Console.WriteLine("Chuh-Chuh-Chuh...");
        }

        public void Krya()
        {
            Console.WriteLine("Krya-Krya-Krya...");
        }

        public override void Eat()
        {
            Console.WriteLine("Oh! My seeds and fruits!");
        }
    }
}
