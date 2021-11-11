using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Developer : Employee
    {
        
        public Developer(int emplNo, string name, double amount) : base(emplNo, name, amount)
        {
            
        }
        public override void CalculateSalary()
        {
            _PA = (double)40 / 100 * BasicSalary;
            _OT = (double)30 / 100 * BasicSalary;
            Console.WriteLine("PA       : {0}", _PA);
            Console.WriteLine("OT       : {0}", _OT);

        }
        
    }
    
}
