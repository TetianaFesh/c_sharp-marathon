using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task3
{
    public enum ColourEnum
    {
        red,
        green,
        blue
    }

    public interface IColoured
    {
        public ColourEnum Colour { get { return ColourEnum.red; } set { } }
    }
}
