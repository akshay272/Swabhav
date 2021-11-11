using PersonBmiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBmiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
            
        }

        private static void CaseStudy2()
        {
            Person[] manyPersons = new Person[3];
            Person p1 = new Person("Akshay", "male", 68f, 60, 21);
            Person p2 = new Person("Shivam", "male", 75f, 75, 22);
            Person p3 = new Person("Siddhesh", "male", 65f, 65, 22);
            manyPersons[0] = p1;
            manyPersons[1] = p2;
            manyPersons[2] = p3;
            
            p1.eat();
            PrintBMI(p1);
            PrintDetails(p1);
            p1.Workout();
            PrintBMI(p1);
            PrintDetails(p1);
            
            p2.Workout();
            PrintBMI(p2);
            PrintDetails(p2);
            
            p3.eat();
            PrintBMI(p3);
            PrintDetails(p3);
            
        }

        private static void CaseStudy1()
        {
            Person p1 = new Person("Akshay", "male", 25f, 60f, 21);
            p1.eat();
            PrintDetails(p1);
        }

        private static void PrintDetails(Person p)
        {
            Console.WriteLine("name       :    {0}", p.GetName());
            Console.WriteLine("Gender     :    {0}", p.GetGender());
            Console.WriteLine("Age        :    {0}", p.GetAge());
            Console.WriteLine("height     :    {0} mtr", p.GetHieght());
            Console.WriteLine("weight     :    {0} kg", p.GetWeight());
            Console.WriteLine(" ");
        }
        public static void PrintBMI(Person p)
        {
            int MIN_BMI = 20;
            int MAX_BMI = 25;
            Console.WriteLine("{0} Your BMI is : {1} kg/m2", p.GetName(), p.GetBmi());
            if (p.GetBmi() < MIN_BMI)
            {
                Console.WriteLine("OOPS!....You are Under-Weight");
            }
            else if (p.GetBmi() > MAX_BMI)
            {
                Console.WriteLine("OOPS!.....You are Over-Weight");
            }
            else
            {
                Console.WriteLine("Great......You have Normal body structure");
            }
            Console.WriteLine(" ");
        }
        /*public static void PrintAccountDetails(Account[] ac)
        {
            for (int i = 0; i < ac.Length; i++)
            {
                Console.WriteLine("a/c number      :    {0}", ac[i].GetAccountNumber());
                Console.WriteLine("a/c holder name :    {0}", ac[i].GetName());
                Console.WriteLine("a/c balance     : Rs {0}", ac[i].GetBalance());
                Console.WriteLine(" ");
            }

        }*/
        
    }
}
