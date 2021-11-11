using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingAccount : Account
    {
        public SavingAccount(int accNumber, string name, double balance): base(accNumber, name, balance)
        {
            Console.WriteLine("Saving Account consturctor : ");
        }
        public override void WithDraw(double amount)
        {
            int MIN_BALANCE = 500;
            if((_balance - amount) > MIN_BALANCE)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("limit reach");
            }
        }
    }
}
