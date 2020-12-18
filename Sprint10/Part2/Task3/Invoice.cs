using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task3
{
    public enum InvoiceType
    {
        Final,
        Proposed
    };
    class Invoice
    {
        public InvoiceType InvoiceType { get; set; }
        public virtual double GetDiscount(double amount)
        {
            return amount;
        }
    }
}
