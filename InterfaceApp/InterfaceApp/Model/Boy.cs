using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IManeer, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is Departing....Good By");
        }

        public void Lough()
        {
            Console.WriteLine("Boy is Loughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy wish u good luck");
        }
    }
}
