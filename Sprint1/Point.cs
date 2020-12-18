using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Point
    {
        private  int x;
        private  int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int[] GetXYPair()
        {
            int[] array = new int[2] { x, y };
            return array;
        }

        protected internal double Distance(int _x, int _y)
        {
            return Math.Sqrt(Math.Pow((_x - x), 2) + Math.Pow((_y - y), 2));
        }

        protected internal double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow((x - point.x), 2) + Math.Pow((y - point.y), 2));
        }

        public static explicit operator double(Point point)
        {
            return Math.Sqrt(Math.Pow((0 - point.x), 2) + Math.Pow((0 - point.y), 2));
        }
    }
}
