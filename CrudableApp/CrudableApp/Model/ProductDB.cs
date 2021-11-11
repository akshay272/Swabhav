using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("ProductDB Create");
        }
        public void Read()
        {
            Console.WriteLine("ProductDB Read");
        }
        public void Update()
        {
            Console.WriteLine("ProductDB update");
        }
        public void Delete()
        {
            Console.WriteLine("ProductDB Delete");
        }
    }
}
