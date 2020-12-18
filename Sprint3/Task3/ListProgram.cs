using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint3.Task3
{
    class ListProgram
    {
        public static List<int> ListWithPositive(List<int> list)
        {
            List<int> outputList = list.FindAll(item => item > 0 && item <= 10);
            return outputList;
        }
    }
}
