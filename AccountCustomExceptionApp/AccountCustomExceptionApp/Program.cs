using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCustomExceptionApp.Model;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("AKshay", 1001, 5000);
            try
            {
                acc1.Withdraw(4501);   
            }

            catch (InsufficienFundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("execute not matter exception or not");
                PrintDetails(acc1);


            }

        }

        private static void PrintDetails(Account acc1)
        {
            Console.WriteLine("a/c number      :    {0}", acc1.GetAccountNumber());
            Console.WriteLine("a/c holder name :    {0}", acc1.GetName());
            Console.WriteLine("a/c balance     : Rs {0}", acc1.GetBalance());
            Console.WriteLine(" ");
        }

    }
}
