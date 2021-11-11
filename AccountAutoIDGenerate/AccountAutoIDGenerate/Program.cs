using System;
using AccountAutoIDGenerate.Model;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountAutoIDGenerate
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
            Account account1 = new Account("Akshay", 4000);
            Account account2 = new Account("Siddhes", 10000);
            Account account3 = new Account("Shivam", 20000);
            Console.WriteLine(account1.Id);
            Console.WriteLine(account2.Id);
            Console.WriteLine(account3.Id);
            
            PrintDetails(account1);
            PrintDetails(account2);
            PrintDetails(account3);
            
            Reflector rf = new Reflector();
            rf.DoReflection(typeof(Account));

        }
       
        private static void PrintDetails(Account ac)
        {
            Console.WriteLine("Account holder Id       :     {0}", ac.Id);
            Console.WriteLine("Account holder Name     :     {0}", ac.Name);
            Console.WriteLine("Account holder Gender   :     {0}", ac.Gender);
            Console.WriteLine("Current Balance         : Rs. {0}", ac.Balance);
            Console.WriteLine(" ");
        }
    }
}
