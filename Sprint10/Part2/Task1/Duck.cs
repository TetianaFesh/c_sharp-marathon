using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task1
{
    class Duck : Bird, IKryaking
    {
        public void Krya()
        {
            Console.WriteLine("Krya-Krya!");
        }

        public override void Move()
        {
            Console.WriteLine("I can swimm!");
        }
    }
}
