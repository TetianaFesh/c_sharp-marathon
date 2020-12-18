using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task4
{
    public class Room<T>: ICloneable, IComparable where T : IShape 
    {
        public double Height { get; set; }
        public T Floor { get; set; }

        public double Volume()
        {
            return Floor.Area() * Height;
        }

        public object Clone()
        {
            return new Room<T>
            {
                Height = this.Height,
                Floor = (T)this.Floor.Clone()
            };
        }   
        
        public int CompareTo(object o)
        {
            Room<T> room = o as Room<T>;
            if (room != null)
                return this.Floor.Area().CompareTo(room.Floor.Area());
            else
                throw new Exception("Unable to compare");
        }
    }
}
