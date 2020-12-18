using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task4
{
    public class Rectangle : IShape, ICloneable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area()
        {
            return Length * Width;
        }
        public object Clone()
        {
            return new Rectangle { Length = this.Length, Width = this.Width };
        }
    }
}
