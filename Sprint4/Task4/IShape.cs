using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task4
{
    public interface IShape
    {
        double Area()
        {
            return 0;
        }

        object Clone();
    }
}
