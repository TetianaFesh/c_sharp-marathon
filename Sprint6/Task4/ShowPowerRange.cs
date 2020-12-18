using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task4
{
    class ShowPowerRange
    {
        public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
        {
            if (start > finish || start < 0 || finish < 0)
            {
                yield return 0;
            }
            else if (degree == 0)
                yield return 1;
            else
            {
                int i = 1;
                for (i = 1;  i <= finish; i++)
                {
                    if (Math.Pow(i, degree) <= finish && Math.Pow(i, degree) >= start)
                    {
                        yield return (int)Math.Pow(i, degree);
                    }
                    if (Math.Pow(i, degree) > finish)
                        break;
                }
            }
        }

        //static void Main()
        //{
        //    foreach (int item in PowerRanger(1, 10, 100))
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
