using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9.Task1
{
    class CalcAsync1
    {
        public static async void PrintSeqAsync(int n)
        {
            Console.WriteLine("Seq[{0}] = {1}", n, await Task.Run(() => Calc.Seq(n)));
        }

        static void Main()
        {
            int n = 10;
            PrintSeqAsync(n);
            Console.ReadKey();
        }
    }
}
