using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4.Task3
{
    public class Example
    {
        public static void Do()
        {
            ColouredDocument doc1 = new ColouredDocument(ColourEnum.green);
            doc1.Name = "Document1";
            Console.WriteLine(doc1.Name);
            ((IDocument)doc1).Rename("Document2");
            Console.WriteLine(doc1.Name);
        }
    }
}