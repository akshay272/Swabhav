using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSerielization.Model
{
    [Serializable]
    class Account
    {
        private double _balance;

        public Account(float _balance)
        {
            this._balance = _balance;
        }
        public void Deposite(double amt)
        {
            this._balance += amt;
            Console.WriteLine("Amount Deposited Successfully");
        }
        public void WithDraw(double amt)
        {
            this._balance -= amt;
            Console.WriteLine("Amount withdraw Succesfully");
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
