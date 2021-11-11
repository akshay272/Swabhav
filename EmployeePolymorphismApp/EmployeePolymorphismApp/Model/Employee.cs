using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    abstract class Employee
    {
        protected int _emplNo;
        protected string _name;
        protected double _basicSalary;
        protected string _post;
        protected double _HRA;
        protected double _TA;
        protected double _DA;
        protected double _PA;
        protected double _OT;
        protected double _perks;
        

        public Employee(int emplNo, string name, double basicSalary)
        {
            this._emplNo = emplNo;
            this._name = name;
            this._basicSalary = basicSalary;
            
        }
        public abstract void CalculateSalary();

        public int EmplNo
        {
            get
            {
                return _emplNo;
            }
        }
        
        
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
    }
}
