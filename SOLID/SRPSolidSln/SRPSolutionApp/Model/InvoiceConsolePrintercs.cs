using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPSolutionApp.Model;
namespace SRPSolutionApp.Model
{
    class InvoiceConsolePrintercs
    {

        public InvoiceConsolePrintercs(Invoice invoice)
        {
            invoice = new Invoice(invoice.Id, invoice.Description, invoice.Amount, invoice.Tax, invoice.Discount);
        }
        public void PrintDetails(Invoice invoice)
        {

            Console.WriteLine("Invoice Id: {0}", invoice.Id);
            Console.WriteLine("Invoice Description: {0}", invoice.Description);
            Console.WriteLine("Invoice Amount: {0}", invoice.Amount);
            Console.WriteLine("Invoice GST tax: {0}%", invoice.Tax);
            Console.WriteLine("Invoice Discount: {0}%", invoice.Amount);
            Console.WriteLine("Discounted amount: {0}", invoice.CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", invoice.CalculateTax());
            Console.WriteLine("Final amount: {0}", invoice.CalculateFinalAmount());
        }
    }
}
