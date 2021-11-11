using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritenceConstructorApp2.Model;

namespace InheritenceConstructorApp2.Model
{
    class Child : Parent
    {
        public Child():base(100)
        {
            Console.WriteLine("child created : hard Coded value");
        }
        public Child(int foo): base(foo)
        {
            Console.WriteLine("dynamic value: parematerize constructor");
        }
    }
}
