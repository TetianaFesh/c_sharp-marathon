using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Sprint8.Task4
{
    class MyProgram
    {
        public static void Counter(int number)
        {
            new Thread(() => { int factorial = Factorial(number); Console.WriteLine("Factorial is: {0}", factorial); }).Start();
            new Thread(() => { int fibonaci = Fibonacci(number); Console.WriteLine("Fibbonaci number is: {0}", fibonaci); }).Start();    
        }

        public static int Fibonacci(int n)
        {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;       
        }

        public static int Factorial(int n)
        {
            object locker = new object();
            lock (locker)
            {
                return Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
            }
        }
        //static void Main()
        //{
        //    Counter(4);
        //}
    }
}
