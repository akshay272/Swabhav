using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Accountant : Employee
    {
        
        public Accountant(int emplNo, string name, double basicSalary) :base(emplNo, name, basicSalary)
        {

        }

        public override void CalculateSalary()
        {
            _perks = (double)30 / 100 * BasicSalary;
            Console.WriteLine("Perks    : {0}", _perks);
            
        }
        
    }
}
