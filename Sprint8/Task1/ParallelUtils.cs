using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sprint8.Task1
{
    class ParallelUtils<T, TR>
    {
        public Func<T, T, TR> Operation;
        public T Operand1;
        public T Operand2;
        public TR Result { get; set; }
        public ParallelUtils(Func<T, T, TR> operation, T operand1, T operand2)
        {
            Operation = operation;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public void StartEvaluation()
        {
            new Thread(() => { Result = Operation(Operand1, Operand2); Evaluate(); }).Start();
        }
        public void Evaluate()
        {
            Thread thread = new Thread(() => { Result = Operation(Operand1, Operand2); });
            thread.Start();
            thread.Join();
        } 
    }
}
