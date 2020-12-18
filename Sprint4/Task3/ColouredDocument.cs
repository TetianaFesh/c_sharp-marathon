using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task3
{
    public class ColouredDocument : IColoured, IDocument
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public ColourEnum Colour { get; set; }

        public ColouredDocument(ColourEnum _color)
        {
            Colour = _color;
        }

        public ColouredDocument()
        {
        }
    }
}
