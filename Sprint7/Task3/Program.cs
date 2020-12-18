using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint7.Task3
{
    class Program
    {
        public int ProductWithCondition(List<int> list, Func<int, bool> predicate)
        {
            if (list.Count != 0)
            {
                IEnumerable<int> res = list.Where(x => predicate(x));
                int product = 1;
                foreach (var item in res)
                {
                    product *= item;
                }
                return product;
            }
            else return 1;
        }
    }
}
