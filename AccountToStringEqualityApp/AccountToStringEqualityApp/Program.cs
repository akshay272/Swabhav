using AccountToStringEqualityApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountToStringEqualityApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }

        private static void CaseStudy2()
        {
            Account acc1 = new Account("Siddhesh", 101, 70000);
            Account acc2 = new Account("Akshay", 101, 45000);
            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine("\n Refferencial Equality : {0} ", acc1 == acc2);
            Console.WriteLine("Value Based Equality  : {0} ", acc1.Equals(acc2));
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account("Akshay ", 1001, 45000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());

        }
    }
}
