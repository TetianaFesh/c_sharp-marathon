using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task4
{
    public class RoomComparerByVolume<T>: IComparer where T: IShape
    {
        public int Compare(object o1, object o2)
        {
            Room<T> r1 = (Room<T>)o1;
            Room<T> r2 = (Room<T>)o2;
            if (r1.Volume() > r2.Volume())
                return 1;
            else if (r1.Volume() < r2.Volume())
                return -1;
            else return 0;
        }
    }
}
