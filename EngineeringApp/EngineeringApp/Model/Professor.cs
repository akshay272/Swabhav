using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.Model
{
    class Professor : SalariedEmp
    {
        private double _bonus;
        private double _totalSalary;
        private double _basicSalary;
        private float bonusPercent = 50;

        public Professor(int id, string address, string dateofbirth, double basicsalary) : base(id, address, dateofbirth, basicsalary)
        {
            _bonus = bonusPercent;
            _basicSalary = basicsalary;
        }
        public double TotalSalary
        {
            get
            {
                return _totalSalary;
            }
        }
        public override double CalcSalary()
        {
            double initialSalary = (_bonus / 100) * _basicSalary;
            _totalSalary = initialSalary + _basicSalary;
            return TotalSalary;
        }
        public override string ExtraThings()
        {
            Console.WriteLine("total salary: " + CalcSalary());
            return string.Empty;
        }
    }
}
