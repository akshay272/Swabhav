
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetGenericApp.Model;
namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Student s1 = new Student(101, "Akshay", "Thane");
            Student s2 = new Student(101, "Akshay", "Thane");
            HashSet<Student> hashStudent = new HashSet<Student>();
            hashStudent.Add(s1);
            hashStudent.Add(s2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            Console.WriteLine("Count : {0}", hashStudent.Count());
        }

        private static void CaseStudy1()
        {
            HashSet<int> hash = new HashSet<int>();
            hash.Add(100);
            hash.Add(50);
            hash.Add(200);
            hash.Add(50);
            hash.Add(200);
            Console.WriteLine("total Elements : {0}", hash.Count());
            
            foreach(int item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
