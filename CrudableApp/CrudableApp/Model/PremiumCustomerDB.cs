using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class PremiumCustomerDB : CustomerDB
    {
        public override void Delete()
        {
            Console.WriteLine("PremiumCustomerDB delete");
        }

        public override void Update()
        {
            Console.WriteLine("PremiumCustomerDB Update");
        }
    }
}
