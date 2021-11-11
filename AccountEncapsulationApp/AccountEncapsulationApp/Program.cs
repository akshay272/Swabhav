using AccountEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
            Console.ReadKey();
        }
        private static void Part2()
        {
            Account[] manyAccounts = new Account[3];
            Account a1 = new Account("Akshay Sawant", 10001, 8000);
            Account a2 = new Account("Siddhesh Chikane", 10002, 7000);
            Account a3 = new Account("Shivam Sutar", 10003, 9200);
            manyAccounts[0] = a1;
            manyAccounts[1] = a2;
            manyAccounts[2] = a3;

            a1.Deposite(2000);
            a2.Withdraw(6600);
            a3.Withdraw(3000); 

            PrintAccountDetails(manyAccounts);

            Account wealthy = WealthyPerson(manyAccounts);
            PrintAccountDetails(wealthy);

            DistributeWealth(manyAccounts);
            PrintAccountDetails(manyAccounts);
        }

        private static void DistributeWealth(Account[] ac)
        {
            Account wealthy = WealthyPerson(ac);
            double balanceDistribute = wealthy.GetBalance() - 500;
            wealthy.Withdraw(balanceDistribute);
            for (int i=0; i<ac.Length; i++)
            {
                if(ac[i].GetAccountNumber() != wealthy.GetAccountNumber())
                {
                    ac[i].Deposite(balanceDistribute / (ac.Length - 1));
                }
                else
                {
                    continue;
                }
            }
            
        }

        private static Account WealthyPerson(Account[] ac)
        {
            double wealthyAccountBalance = ac[0].GetBalance();
            Account wealthyAccount = ac[0];
            for (int i = 1; i < ac.Length; i++)
            {
                if(wealthyAccountBalance < ac[i].GetBalance())
                {
                    wealthyAccountBalance = ac[i].GetBalance();
                    wealthyAccount = ac[i];
                }
            }
            Console.WriteLine("Wealthy person's details are: ");
            return wealthyAccount;
        }

        private static void Part1()
        {
            Account a1 = new Account("Akshay Sawant", 100001, 5000);
            PrintAccountDetails(a1);
            a1.Deposite(2500);
            PrintAccountDetails(a1);

            Account a2 = new Account("Siddhesh Chikane", 100002, 7000.0);
            PrintAccountDetails(a2);
            a2.Withdraw(6501);
            PrintAccountDetails(a2);

            Account a3 = new Account("Shivam Sutar", 100003, 10000.0);
            a3.Withdraw(2500);
            PrintAccountDetails(a3);
            
        }
        public static void PrintAccountDetails(Account[] ac)
        {
            for (int i = 0; i < ac.Length; i++)
            {
                Console.WriteLine("a/c number      :    {0}", ac[i].GetAccountNumber());
                Console.WriteLine("a/c holder name :    {0}", ac[i].GetName());
                Console.WriteLine("a/c balance     : Rs {0}", ac[i].GetBalance());
                Console.WriteLine(" ");
            }

        }
        public static void PrintAccountDetails(Account ac)
        {
            Console.WriteLine("a/c number      :    {0}", ac.GetAccountNumber());
            Console.WriteLine("a/c holder name :    {0}", ac.GetName());
            Console.WriteLine("a/c balance     : Rs {0}", ac.GetBalance());
            Console.WriteLine(" ");
        }
    }
}
