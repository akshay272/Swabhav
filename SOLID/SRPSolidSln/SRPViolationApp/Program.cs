using System;
using SRPSolutionApp.Invoice;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(101, "Billing amount of Laptop ", 50000, 10f, 25f);
            invoice1.PrintDetails();

        }
    }
}
