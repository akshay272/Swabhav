using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Invoice
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string description, double amount, float tax, float discount )
        {
            this._id = id;
            this._description = description;
            this._amount = amount;
            this._tax = tax;
            this._discount = discount;
        }
        public double CalculateDiscount()
        {
            _discount =(float)( _amount * _discount / 100);
            return _discount;
        }
        public double CalculateTax()
        {
            _tax = (float)_amount * _tax / 100;
            return _tax;
        }
        public double CalculateFinalAmount()
        {
            return _amount + _tax - _discount;
        }
        public void PrintDetails()
        {
            
            Console.WriteLine("Invoice Id: {0}", _id);
            Console.WriteLine("Invoice Description: {0}", _description);
            Console.WriteLine("Invoice Amount: {0}", _amount);
            Console.WriteLine("Invoice GST tax: {0}%", _tax);
            Console.WriteLine("Invoice Discount: {0}%", _discount);
            Console.WriteLine("Discounted amount: {0}", CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", CalculateTax());
            Console.WriteLine("Final amount: {0}", CalculateFinalAmount());
        }
    }
}
