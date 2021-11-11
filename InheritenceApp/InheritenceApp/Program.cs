using System;
using InheritenceApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();
            Console.ReadKey();
        }

        private static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "hello World";
            Console.WriteLine(x.GetType());
            x = 15.45f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        private static void AtThePark(Man x)
        {
            Console.WriteLine("At the park");
            x.Play();

        }

        private static void CaseStudy1()
        {
            Man x;
            x = new Man();
            x.Walk();
            x.Play();
            x.Read();
        }
        private static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Read();
            y.Walk();
            
        }
        private static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
            x.Jump();
        }
        
    }
}
