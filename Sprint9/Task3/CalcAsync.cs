using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9.Task1
{
    class CalcAsync
    {
        public static async Task<int> SeqAsync(int n)
        {
             return await Task.Run(() => Calc.Seq(n));
        }

        public static async void PrintSeqElementsConsequentlyAsync(int quant)
        {
            for (int i = 1; i <= quant; i++ )
            {
                Console.WriteLine("Seq[{0}] = {1}", i, await Task.Run(() => SeqAsync(i)));
            }
        }

        public static async void PrintSeqElementsInParallelAsync(int quant)
        {
            var tasks = GetSeqAsyncTasks(quant);
            await Task.WhenAll(tasks);
            int k = 1;
            for(int  i = 0; i < quant; i++)
            {
                Console.WriteLine("Seq[{0}] = {1}", k++, tasks[i].Result);
            }

        }

        public static Task<int>[] GetSeqAsyncTasks(int quant)
        {
            Task<int>[] tasks = new Task<int>[quant];
            int j = 0;
            for (int i = 1; i <= quant; i++, j++)
            {
                tasks[j] =  SeqAsync(i);
            }
            return tasks;
        }
        static void Main()
        {
            int n = 10;
            //PrintSeqAsync(n);
            Console.ReadKey();
        }
    }
}
