using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("OrderDB read");
        }

        public void Delete()
        {
            Console.WriteLine("OrderDB delete");
        }

        public void Read()
        {
            Console.WriteLine("orderDB read");
        }

        public void Update()
        {
            Console.WriteLine("orderDB Update");
        }
    }
}
