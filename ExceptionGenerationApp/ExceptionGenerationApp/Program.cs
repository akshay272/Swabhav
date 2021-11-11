using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int firstNumber = Convert.ToInt32(args[0]);
            int secondNumber = Convert.ToInt32(args[1]);
            
            int result = firstNumber / secondNumber;
            
            Console.WriteLine("{0} , {1} , {2}", firstNumber, secondNumber, result);
            Console.WriteLine(" end of main");
            Main(args);
            Console.ReadKey();

            //System.OverflowException
            //Line no 14

            //.FormatException
            //Line no 14


        }
    }
}
