using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task2
{
    public interface IAnimal
    {
        string Name { get; set; }
        void Voice();
        void Feed();
    }
}
