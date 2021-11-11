using InheritenceConstructorApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConstructorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            Console.WriteLine(c1.Foo);
            Child c2 = new Child(500);
            Console.WriteLine(c2.Foo);
            Console.ReadKey();
        }
    }
}
