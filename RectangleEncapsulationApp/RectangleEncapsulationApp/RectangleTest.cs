using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            Rectangle large = new Rectangle();
            
            small.SetHeight(-50);
            small.SetWidth(20);
            int smallArea = small.CalculateArea();
            Console.WriteLine("Rectangle1 : height = {0}, width = {1}, area ={2} \n", small.GetHeight(), small.GetWidth(), smallArea);

            large.SetHeight(80);
            large.SetWidth(250);
            int largeArea = large.CalculateArea();
            Console.WriteLine("Rectangle2 : height = {0}, width = {1} area = {2} \n ", large.GetHeight(), large.GetWidth(), largeArea);
            
            Console.ReadKey();
        }
    }
}
