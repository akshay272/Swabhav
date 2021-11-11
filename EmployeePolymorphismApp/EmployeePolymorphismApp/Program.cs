using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Manager(1001, "Akshay", 25000);
            PrintDetatils(e);
            e.CalculateSalary();
            
            Employee e2 = new Accountant(1002, "Shivam", 20000);
            PrintDetatils(e2);
            e2.CalculateSalary();
           
            Employee e3 = new Developer(1003, "Siddhesh", 15000);
            PrintDetatils(e3);
            e3.CalculateSalary();
            
            Console.ReadKey();
        }
        static void PrintDetatils(Employee emp)
        {
            Console.WriteLine("***************Salary Slip*******************");
            Console.WriteLine("Posst    : {0}", emp.GetType().Name);
            Console.WriteLine("Emp Id : {0}   Name : {1}   Salary : {2}", emp.EmplNo, emp.Name, emp.BasicSalary);
            
        }
    }
}
