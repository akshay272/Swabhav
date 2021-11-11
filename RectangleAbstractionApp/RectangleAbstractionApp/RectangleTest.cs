
using RectangleAbstractionApp.Model;
using System;


namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.height = 10;
            small.width = 5;
            int area = small.CalculateArea();
            Console.WriteLine("Small Rectangle details :");
            Console.WriteLine("height : "+ small.height);
            Console.WriteLine("width : " + small.width);
            Console.WriteLine("area of small Rectangle : " + area);

            //Large Rectangle
            Rectangle large;
            large = new Rectangle();
            large.width = 80;
            large.height = 120;
            int largeArea = large.CalculateArea();
            Console.WriteLine("Small Rectangle details :");
            Console.WriteLine("height : " + large.height);
            Console.WriteLine("width : " + large.width);
            Console.WriteLine("area of large Rectangle : " + largeArea);

            Rectangle temp = small;
            Console.WriteLine("\n small width : "+ small.width);
            Console.WriteLine( "temp width : " + temp.width);

            temp.width = temp.width + 7;
            Console.WriteLine("smll with : "+ small.width);
            Console.WriteLine("temp width :" + temp.width);

            Console.WriteLine("small: {0}\n big : {1} \n temp: {2} ", small.GetHashCode(), large.GetHashCode(), temp.GetHashCode());
            Console.ReadKey();

            

        }
    }
}
