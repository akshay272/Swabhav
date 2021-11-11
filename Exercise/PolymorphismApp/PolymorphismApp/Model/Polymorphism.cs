using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp.Model
{
    class Polymorphism
    {
        public void Print(int value)
        {
            Console.WriteLine("int value is : {0}", value);
        }
        public void Print(float value)
        {
            Console.WriteLine("float value is : {0}", value);
        }
        public void Print(double value)
        {
            Console.WriteLine("double value is : {0}", value);
        }
        public void Print(bool value)
        {
            Console.WriteLine("bool value is : {0}", value);
        }
        public void Print(char value)
        {
            Console.WriteLine("char Character is : {0}", value);
        }
        public void Print(string str)
        {
            Console.WriteLine("String value is : {0}", str);
        }

    }
}
