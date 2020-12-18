using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sprint8.Task2
{
    class MainThreadProgram
    {
        public (Thread, Thread) Calculator()
        {
            Thread productThread = new Thread(new ThreadStart(Product));
            productThread.Start();
            Thread sumThread = new Thread(new ThreadStart(Sum));
            sumThread.Start();
            return (sumThread, productThread);
        }

        public void Product()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Product is {0}.", list.Aggregate((total, next) => total * next));
        }

        public void Sum()
        {
            double sum = 0;
            Console.WriteLine("Enter the 1st number :");
            sum += Convert.ToDouble(Console.ReadLine());;
            Console.WriteLine("Enter the 2nd number :");
            sum += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 3th number :");
            sum += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 4th number :");
            sum += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 5th number :");
            sum += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum is {0}.", sum);
        }
    }
}
