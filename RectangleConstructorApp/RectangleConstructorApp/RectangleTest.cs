using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }

        private static void CaseStudy2()
        {
            Rectangle r1 = new Rectangle(-10, 50, "Green");
            PrintDetails(r1);
            Rectangle r2 = new Rectangle(200, 70, "Yellow","pink");
            PrintDetails(r2);
        }

        public static void CaseStudy1()
        {
            Rectangle r3 = new Rectangle(45, 50, "red" );
            PrintDetails(r3);
        }

        private static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Width : {0}",r.GetWidth());
            Console.WriteLine("height : {0}", r.GetHeight());
            Console.WriteLine("Color : {0}", r.GetColor());
            Console.WriteLine("BorderColor : {0}", r.GetBorderColor());
            Console.WriteLine("Area : {0}", r.CalculateArea());
        }

    }
}
