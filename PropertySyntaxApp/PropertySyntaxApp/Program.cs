using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foo f = new foo();
            f.Bar = 200;
            Console.WriteLine(f.Bar);
            Console.WriteLine(f.Random); 
            Console.ReadKey();
        }
    }
}
