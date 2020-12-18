using Sprint9.Task1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sprint9.Task5
{
    class CalcAsync
    {
        public async void PrintSpecificSeqElementsAsync(int[] n)
        {
            var tasks = new List<Task>();
            Task allTasks = null;
            List<string> exceptions = new List<string>();
            
                try
                {
                for (int i = 0; i < n.Length; i++)
                {
                    tasks.Add(Task.Run(() => { Console.WriteLine("Seq[{0}] = {1}", n[i], Calc.Seq(n[i])); }));
                    allTasks = Task.WhenAll(tasks);
                    await allTasks;
                }

                }
                catch (Exception ex)
                {
                    foreach (var inx in allTasks.Exception.InnerExceptions)
                    {
                        Console.WriteLine("Inner exception: " + inx.Message);
                    }
                }
            
        }
    }
}
