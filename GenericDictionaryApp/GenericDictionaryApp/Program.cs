using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDictionaryApp.Model;

namespace GenericDictionaryApp
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
            var map = new Dictionary<Student, Student>();
            var s1 = new Student(12, 10, "Akshay", "Thane");
            var s2 = new Student(10, 12, "Siddhesh", "Mumbai");
            var s3 = new Student(12, 10, "AKSHAY", "Mumbai");

            map.Add(s1, s1);
            map.Add(s2, s2);
            Console.WriteLine();

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            if (!map.ContainsKey(s3))
            {
                map.Add(s3, s3);
            }
            Console.WriteLine(map.Count());
        }

        private static void CaseStudy1()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            //dict.Add(1, "ONE");
            dict.Add(2, "two");

            Console.WriteLine("Count {0}", dict.Count());

            foreach(KeyValuePair<int , string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value); 
            }
        }
    }
}
