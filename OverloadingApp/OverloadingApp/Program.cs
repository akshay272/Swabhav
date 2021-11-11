using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    class Program
    {
        private static void PrintDetails(int intNumber)
        {
            Console.WriteLine("Integer number : " + intNumber);
        }

        private static void PrintDetails(float floatNumber)
        {
            Console.WriteLine("floating number : " + floatNumber);
        }

        public static void PrintDetails(string studentName)
        {
            Console.WriteLine("Student name : " + studentName);
        }

        private static void PrintDetails(double doubleNumber)
        {
            Console.WriteLine("double number : " + doubleNumber);
        }

        private static void PrintDetails(char character)
        {
            Console.WriteLine("Character : " + character);
        }

        private static void PrintDetails(bool booleanValue)
        {
            Console.WriteLine("Boolean value : " + booleanValue);
        }
        private static void Main(string[] args)
        {
            //integer value
            PrintDetails(100);
            PrintDetails(20.4f);
            PrintDetails(45.54);
            PrintDetails("AKshay Sawant");
            PrintDetails('a');
            PrintDetails(true);
            Console.ReadKey();
        }
    }
}
