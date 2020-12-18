using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint8.Task6
{
    class PersonInTheShop
    {
        public void Enter()
        {

        }

        public void SelectGroceries()
        {

        }

        public void Pay()
        {

        }

        public void Leave()
        {
            while (count > 0)
            {
                sem.WaitOne();

                sem.Release();

                count--;
            }
        }
    }
}
