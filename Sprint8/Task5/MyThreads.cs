using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sprint8.Task5
{
    class MyThreads
    {
        public static readonly object Den = new object();
        public static readonly object Ada = new object();

        public static int n;
        public static int m;

        public static Thread Thread1 = new Thread(
            () =>
            {
                lock (Ada)
                {
                    for (int i = 0; i < 5; i++, n++)
                    {
                        Console.WriteLine("Thread1 n = " + n);
                        ThreadsDemo.ExtraEvaluation(i);
                    }
                }
                Thread.Sleep(1000);
                Thread.Yield();
                    lock (Den)
                    {
                        for (int i = 0; i < 5; i++, m++)
                            Console.WriteLine("Thread1 m = " + m);
                        Console.WriteLine("Thread1 success!");
                    }
                
            }
        );

        public static Thread Thread2 = new Thread(
            () =>
            {
                
                lock (Ada)
                {
                    
                    lock (Den)
                    {
                        for (int i = 0; i < 5; i++, m++)
                        Console.WriteLine("Thread2 m = " + m);

                    
                        Thread.Yield();

                        for (int i = 0; i < 5; i++, n++)
                            Console.WriteLine("Thread2 n = " + n);
                        Console.WriteLine("Thread2 success!");
                    }
                }
            }
        );
    }

    class ThreadsDemo
    {
        public static void ExtraEvaluation(int i)
        {

        }

        //static void Main()
        //{
        //    MyThreads.Thread1.Start();
        //    MyThreads.Thread2.Start();
        //}
    }
}
