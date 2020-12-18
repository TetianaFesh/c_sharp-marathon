using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint3.Task1
{
    public class CalcProgram
    {
        public delegate int CalcDelegate(int a, int b, char sighn);

        public static int Calc(int a, int b, char sighn)
        {
            switch (sighn)
            {
                case '+': return a + b; 
                case '-': return a - b; 
                case '*': return a * b;
                case '/': if (b == 0) return 0;
                    else return a / b;
            }
            return 0;
        }


            CalcDelegate funcCalc = Calc;

    }
}
