using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    public class Man : IManeer
    {
        public void Depart()
        {
            Console.WriteLine("Man Departing.... bye");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wish u good luck");
        }
    }
}
