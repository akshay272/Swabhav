using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(e.StackTrace);
                
            }
            finally
            {
                Console.WriteLine("end of Main");
            }
            
            Console.ReadKey();
        }
        public static void M1()
        {
            Console.WriteLine("inside M1");
            M2();
        }
        public static void M2()
        {
            Console.WriteLine("inside M2");
            M3();
        }
        public static void M3()
        {
            Console.WriteLine("inside M3");
            throw new Exception("some thing went wrong");
        }
    }
}
