using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        protected int _accountNumber;
        protected string _name;
        protected double _balance;
       
        public Account(int acNumber, string name, double balance)
        {
            this._accountNumber = acNumber;
            this._name = name;
            this._balance = balance;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
        }
        public abstract void WithDraw(double amount);
        
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
