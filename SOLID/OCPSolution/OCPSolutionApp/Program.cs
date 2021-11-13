using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;
using OCPSolutionApp.Client;
namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposite("AKshay", 100000, 10, new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Interest : " + fd1.SimpleIntest());

        }
    }
}
