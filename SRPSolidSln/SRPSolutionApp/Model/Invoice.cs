using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Model
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string description, double amount, float tax, float discount)
        {
            this._id = id;
            this._description = description;
            this._amount = amount;
            this._tax = tax;
            this._discount = discount;
        }
        public double CalculateDiscount()
        {
            _discount = (float)(_amount * _discount / 100);
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

        public int Id
        {
            get { return _id; }
        }
        public string Description
        {
            get { return _description; }
        }
        public double Amount
        {
            get { return _amount; }
        }
        public float Tax
        {
            get { return _tax; }
        }
        public float Discount
        {
            get { return _discount; }
        }
    }
}