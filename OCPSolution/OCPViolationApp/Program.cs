using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPViolationApp.Model;
namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposite fd1 = new FixedDeposite("Akshay", 20000, 5, FestivalType.DIWALI);
            Console.WriteLine("Simple Interest : " + fd1.SimpleIntest());
        }
    }
}
