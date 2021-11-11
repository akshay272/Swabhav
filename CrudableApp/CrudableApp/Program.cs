using CrudableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperation(new OrderDB());
            DoDBOperation(new ProductDB());
            DoDBOperation(new PremiumCustomerDB());
            Console.ReadKey();
        }

        private static void DoDBOperation(ICrudable obj)
        {
            Console.WriteLine("Doing all db operation");
            obj.Read();
            obj.Create();
            obj.Delete();
            obj.Update();
            Console.WriteLine(" ");
            
        }
    }
}
