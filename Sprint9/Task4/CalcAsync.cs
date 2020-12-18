using Sprint9.Task1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9.Task4
{
    class CalcAsync
    {
        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i  = 1; i <= n; i++)
            {
                yield return (i, await Task.Run(() => Calc.Seq(i)));
            }
        }

        public static async void PrintStream(IAsyncEnumerable<(int, int)> tuples)
        {
            await foreach(var tuple in tuples)
            Console.WriteLine("Seq[{0}] = {1}", tuple.Item1, tuple.Item2);
        }
    }
}
