using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.CommonModule;
using DIPSolutionApp.HighLevelModule;
namespace DIPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(new FileLogger());
            Console.WriteLine(calc.Calculate(20,10));
            Console.WriteLine(calc.Calculate(40,0));
            
        }
    }
}
