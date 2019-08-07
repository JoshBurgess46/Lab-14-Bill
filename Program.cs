using System;

namespace Lab_14_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill billing = new Bill();
            billing.TaxRate = 0.06;
            billing.Subtotal = 15.80;
            Pay(billing);

            
            TippableBill tip = new TippableBill();
            tip.Subtotal = 8.50;
            tip.TaxRate = 0.06;
            tip.Tip = 2.00;
            Pay(tip);

        }
        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");
        }
    }
}
