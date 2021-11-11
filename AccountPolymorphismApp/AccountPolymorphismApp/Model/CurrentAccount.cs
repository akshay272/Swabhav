using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount:Account
    {
        
        public CurrentAccount(int acNumber, string name, double balance): base(acNumber, name, balance)
        {
            Console.WriteLine("Current Account constructor :");
        }
        public override void WithDraw(double amount)
        {
            int OVER_DRAFT_AMOUNT = -5000;
            if ((_balance - amount) > OVER_DRAFT_AMOUNT)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("overDraft limit reach");
            }
            
        }
    }
}
