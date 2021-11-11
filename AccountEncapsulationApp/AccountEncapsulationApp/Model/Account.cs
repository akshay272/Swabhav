using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Model
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
            if((_balance-amount) < MINIMUM_BALANCE)
            {
                Console.WriteLine("a/c {0} error WithDraw transaction Cancelled : Minimum balance should 500", _accountNumber);
            }
            else
            {
                _balance -= amount;
                Console.WriteLine("Withdraw amount Rs.{0} Successfully in a/c {1}", amount, _accountNumber);
            }
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
