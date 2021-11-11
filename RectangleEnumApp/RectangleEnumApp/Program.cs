using RectangleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Height = 105;
            rect1.Width = 50;
            rect1.BorderColor = ColorType.blue;
            PrintDetails(rect1);

            Rectangle rect2 = new Rectangle();
            rect2.Height = 10;
            rect2.Width = 500;
            rect2.BorderColor = ColorType.green;
            PrintDetails(rect2);
            Console.ReadKey();
        }

        private static void PrintDetails(Rectangle rect)
        {
            Console.WriteLine("Height is : {0}", rect.Height);
            Console.WriteLine("width is : {0}", rect.Width);
            Console.WriteLine("BorderColor is : {0} ", rect.BorderColor);
            Console.WriteLine("Area is : {0}", rect.CalculateArea());
            Console.WriteLine("\n");
        }
    }
}
