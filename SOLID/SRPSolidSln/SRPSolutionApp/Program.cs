using System;
using SRPSolutionApp.Model;

namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "HP Laptop", 50000, 10f, 20f);
            InvoiceHtmlGenerator htmlGenerator = new InvoiceHtmlGenerator();
            htmlGenerator.SaveInvoice(invoice);
        }
    }
}
