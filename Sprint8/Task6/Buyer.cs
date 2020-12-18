using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sprint8.Task6
{
    class Buyer : PersonInTheShop
    {
        static Semaphore sem = new Semaphore(10, 10);
        Thread myThread;

        public Buyer(string thread)
        {
            myThread = new Thread(() => {
                sem.WaitOne();
                Enter();   
                SelectGroceries(); 
                Pay(); 
                Leave();
                sem.Release();
            });
            myThread.Name = thread.ToString();
            myThread.Start();
        }     
    }
}
