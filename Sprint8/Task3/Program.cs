using System;
using System.Threading.Tasks;

namespace Sprint8.Task3
{
    class Program
    {
        static void Tasks()
        {
            int[] sequence_array = new int[10];
            Task[] task1 = new Task[3]
            {
                new Task(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sequence_array[i] = i*i;
                    }
                    Console.WriteLine("Calculated!");
                }),
                new Task(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Bye!");
                }),
                new Task(() => 
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(sequence_array[i]);
                    }
                    Console.WriteLine("Bye!");
                })
            };
            task1[0].Start(); 
            task1[1].Start();
            task1[1].Wait();
            task1[2].Start();
            task1[0].Wait();
            Task.WaitAll(task1);
            Console.WriteLine("Main Done!");    
        }

        //static void Main()
        //{
        //    Tasks();
        //}
    }
}
