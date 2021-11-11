using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineeringApp.Model;
namespace EngineeringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmp p1 = new Professor(101, "Mumbai", "19/06/1974", 40000);
            SalariedEmp p2 = new Professor(102, "Thane", "26/02/1980", 60000);
            Student s1 = new Student(103, "Navi Mumbai", "23/05/2000", "CSE");
            Student s2 = new Student(104, "Pune", "2/01/1999", "Mech");
            PrintDetails(p1);
            PrintDetails(p2);
            PrintDetails(s1);
            PrintDetails(s2);
        }
        public static void PrintDetails(SalariedEmp p)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("id               : " + p.id);
            Console.WriteLine("Address          : " + p.address);
            Console.WriteLine("date of birth    : " + p.dateofbirth);
            Console.WriteLine("basic salary     : " + p.Basicsalary);
            Console.WriteLine("Salry with bonus : " + p.CalcSalary());
            
        }

        public static void PrintDetails(Student s)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID               : " + s.id);
            Console.WriteLine("Address          : " + s.address);
            Console.WriteLine("date of birth    : " + s.dateofbirth);
            Console.WriteLine("branch           : " + s.branch);
        }
    }
}
