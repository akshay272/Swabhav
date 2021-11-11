using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private string _name;
        private int _accountNumber;
        private double _balance;

        public Account(string name, int accountNumber, double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public void Deposite(double amount)
        {
            _balance += amount;
            Console.WriteLine("Amount Deposited successfully :Rs. {0} in a/c {1}", amount, _accountNumber);
        }
        public void Withdraw(double amount)
        {
            int MINIMUM_BALANCE = 500;
            if ((_balance - amount) > MINIMUM_BALANCE)
            {
                _balance -= amount;
                Console.WriteLine("Withdraw amount Rs.{0} Successfully in a/c {1}", amount, _accountNumber);
            }
            throw new InsufficienFundException(this);
        }

        public string GetName()
        {
            return _name;
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}

