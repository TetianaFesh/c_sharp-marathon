using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task1
{
    class Cat : IMoving, IEating, IBasking
    {
        public void Eat()
        {
            Console.WriteLine("Oh! My milk!");
        }

        public void Bask()
        {
            Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }

        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
}
