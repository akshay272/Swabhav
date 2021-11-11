using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class InsufficienFundException : Exception
    {
        private string _message;
        public InsufficienFundException()
        {
            //throw new Exception( "tries to withdraw but due to less fund , withdraw unsuccessfull");
        }

        public InsufficienFundException(Account Acc)
        {
            _message = $"a/c no : {Acc.GetAccountNumber()} have insucfficient funds to withdraw \n " +
                        $"you can't withdraw more than {Acc.GetBalance() - 500}\n"+
                        $"you should have minimum balance of 500\n" +
                        $"Transaction Declined";
        }
            

        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
