using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPolymorphismApp.Model;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            SavingAccount acc1 = new SavingAccount(1001, "Akshay Sawant", 5000);
            acc1.WithDraw(4501);
            PrintDetatis(acc1);

            CurrentAccount acc2 = new CurrentAccount(1002, "Shivam Sutar", 10000);
            acc2.WithDraw(14000);
            PrintDetatis(acc2);
        }

        private static void PrintDetatis(Account ac)
        {
            Console.WriteLine("Account Number      : {0}", ac.AccountNumber);
            Console.WriteLine("Account holder Name : {0}", ac.Name);
            Console.WriteLine("Account Balance     : {0}", ac.Balance);
            Console.WriteLine(" ");
        }
    }
}
