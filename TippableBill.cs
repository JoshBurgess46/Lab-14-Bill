using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_Bill
{
    class TippableBill:Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {

        }
        public TippableBill(double tip, double subtotal, double taxRate) :base(subtotal,taxRate)
        {
            Subtotal = subtotal;
            TaxRate = taxRate;
            Tip = tip;
        }
        public override double CalcTotal()
        {
            return base.CalcTotal() + Tip;//base calls on the parent class method 
        }
    }
}
