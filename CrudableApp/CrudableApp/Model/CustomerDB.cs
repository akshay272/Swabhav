using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudableApp.Model;

namespace CrudableApp.Model
{
    abstract class CustomerDB : ICrudable
    {
        //public CustomerDB() { }
        public void Create()
        {
            Console.WriteLine("Create CustomerDB");
        }

        public abstract void Delete();
        

        public void Read()
        {
            Console.WriteLine("Read CustomerDB");
        }

        public abstract void Update();
        
    }
}
