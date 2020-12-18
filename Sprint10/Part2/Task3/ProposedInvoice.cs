using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task3
{
    class ProposedInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            return amount - amount * 0.05;
        }
    }
}
