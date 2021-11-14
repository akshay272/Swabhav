using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPVoilationApp.HighLevelModule;

namespace DIPVoilationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(LogType.DB);
            Console.WriteLine(calc.Calculate(10,5));
            Console.WriteLine(calc.Calculate(10,0));
        }
    }
}
