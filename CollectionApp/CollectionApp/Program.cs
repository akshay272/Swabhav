using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionApp.Model;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
            Console.ReadKey();
        }

        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("Bag", 1000, 2));
            basket.Add(new LineItem("Shirt", 700, 4));
            basket.Add(new LineItem("Cake", 700, 1));
            basket.Add(new LineItem("Cap", 150, 4));

            double finalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("product Name : {0}, price : {1}, quantity : {2} ", item.GetProductName, item.GetPrice, item.GetQuantity);
                Console.WriteLine("totalPrice : {0}", item.TotalPrice());
                finalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price : {0}", finalPrice);

        }
        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("Bag", 1000, 2));
            basket.Add(new LineItem("Shirt", 700, 4));
            basket.Add(new LineItem("Cake", 700, 1));
            basket.Add(new LineItem("Cap", 150, 4));
            basket.Add("AurionPro");

            double finalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("product Name : {0}, price : {1}, quantity : {2} ", item.GetProductName, item.GetPrice, item.GetQuantity );
                Console.WriteLine("totalPrice : {0}", item.TotalPrice());
                finalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price : {0}", finalPrice);
        }

        /*private static void DisplayItems(ArrayList basket)
        {
            foreach(object item in basket)
            {
                Console.WriteLine("Produc Name : {0}", ite);
            }
            Console.WriteLine("");
        }*/
    }
}
