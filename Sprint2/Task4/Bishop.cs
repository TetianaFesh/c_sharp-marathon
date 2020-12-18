using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint2.Task4
{
    public class Bishop : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }
}
