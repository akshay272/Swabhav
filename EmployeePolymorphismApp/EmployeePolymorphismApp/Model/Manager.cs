using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Manager : Employee
    {
        
        public Manager(int emplNo, string name, double basicSalary) : base(emplNo, name, basicSalary)
        {
            
        }
        public override void CalculateSalary()
        {
            _HRA = (double) 50/100 * BasicSalary;
            _TA = (double) 40/100 * BasicSalary;
            _DA = (double) 30/100 * BasicSalary;
            Console.WriteLine("HRA      : {0}", _HRA);
            Console.WriteLine("TA       : {0}", _TA);
            Console.WriteLine("DA       : {0}", _DA);

        }
        
    }
}
