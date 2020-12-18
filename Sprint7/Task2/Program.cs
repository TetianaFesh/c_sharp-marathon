using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint7.Task2
{
    class Program
    {
        public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
        {
            return inputData.Where((x, i)=> predicate.Invoke(x, i)).Aggregate((x, i) => aggregate(x, i));
            //return res;
        }


    }
}
