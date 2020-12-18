using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9.Task1
{
    static class CalcAsync2
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            Console.WriteLine("Seq[{0}] = {1}", n, await Task.Run(() => Calc.Seq(n)));
        }

        public static void PrintStatusIfChanged(this Task task, ref TaskStatus t)
        {
            Console.WriteLine(task.Status);
        }

        public static void TrackStatus(this Task task)
        {
            var previous_status = task.Status;
            task.PrintStatusIfChanged(ref previous_status);
            while (!task.IsCompleted)
            {
                if (previous_status != task.Status)
                {

                    previous_status = task.Status;
                }
            }
            task.PrintStatusIfChanged(ref previous_status);
        }

        static void Main()
        {
            int n = 10;
            TaskPrintSeqAsync(n);
            Console.ReadKey();
        }
    }
}
