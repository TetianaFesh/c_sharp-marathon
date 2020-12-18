using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task1
{
    class Bird : IFlyable, IEating, IMoving
    {
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }

        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }

        public virtual void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
}
