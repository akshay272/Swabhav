using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountPercent;
        private static int _instanceCount;

        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = 2f;
            _instanceCount += 1;
            Console.WriteLine("Constructor 1");
        }
        public Product(int id, string name, double price, float discountPercent)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discountPercent;
            _instanceCount += 1;
            Console.WriteLine("Constructor 2");
        }
        static Product()
        {
            _instanceCount = 0;
            Console.WriteLine("static constructor");
        }
        public static int Occurences 
        {
            get
            {
                return _instanceCount;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float DiscountPrice
        {
            get
            {
                return _discountPercent;
            }
        }
        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public double CalculateFinalPrice()
        {
            return _price - (_price*_discountPercent/100);
        }

    }
}
