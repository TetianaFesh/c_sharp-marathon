using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task4
{
    public class Trapezoid : IShape, ICloneable
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Width * ((Length1 + Length2) / 2);
        }
        public object Clone()
        {
            return new Trapezoid { Length1 = this.Length1, Length2 = this.Length2,  Width = this.Width };
        }
    }
}
