using ProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.WriteLine("Product Occurences:"+Product.Occurences);
            Console.ReadKey();
        }

        private static void CaseStudy2()
        {
            Product p1 = new Product(101, "Head First Java", 350);
            Console.WriteLine("product 1 : " + p1.InstanceCount);
            Console.WriteLine(Product.Occurences);
            Product p2 = new Product(102, "Head Firs C#", 500, 5f);
            Console.WriteLine("Product 2 : " + p2.InstanceCount);
            Console.WriteLine(Product.Occurences);
            Product p3 = new Product(102, "Head Firs python", 500, 5f);
            Console.WriteLine("Product 3 : "+p3.InstanceCount);
            Console.WriteLine(Product.Occurences);
            
            
        }

        private static void CaseStudy1()
        {
            Product p1 = new Product(101, "Head First Java", 350);
            PrintDetails(p1);
            Product p2 = new Product(102, "Head Firs C#", 500, 5f);
            PrintDetails(p2);
            

        }
        public static void PrintDetails(Product p)
        {
            Console.WriteLine("Product Id             : {0}", p.Id);
            Console.WriteLine("Product name           : {0}",p.Name);
            Console.WriteLine("Product Original price : {0}", p.Price);
            Console.WriteLine("Product discount       : {0}", p.DiscountPrice);
            Console.WriteLine("Product discount price :{0}", p.CalculateFinalPrice());
            Console.WriteLine(" ");
        }
        
    }
}
