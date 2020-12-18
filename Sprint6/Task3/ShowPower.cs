using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Task3
{
    public class ShowPower
    {
        public static IEnumerable<float> SuperPower(int number, int degree)
        {
            double result = 1;
            if (degree == 0)
            {
                    yield return 1;              
            }
            else if (degree < 0 && number == 0)
                yield return 0;
            else
            {
                for (int i = 0; i < Math.Abs(degree); i++)
                {
                    if (degree < 0)
                    {
                        if (number != 0)
                        {
                            result = result * (1.0 / number);
                            yield return (float)result;
                        }
                    }
                    else
                    {
                        result *= number;
                        yield return (float)result;
                    }
                }
            }
        }


        //static void Main()
        //{
        //    foreach (float item in SuperPower(0, -5))
        //    {
        //        Console.WriteLine("{0} ", item);
        //    }
        //}
    }
}
