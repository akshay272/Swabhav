using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _quantity;
        private double _finalPrice;
        public LineItem(string productName, double price, int quantity)
        {
            _productName = productName;
            _price = price;
            _quantity = quantity;
        }
        public string GetProductName
        {
            get
            {
                return _productName;
            }
        }
        public double GetPrice
        {
            get
            {
                return _price;
            }
        }
        public int GetQuantity
        {
            get
            {
                return _quantity;
            }
        }

        public double TotalPrice()
        {
            double totalPrice = _price * _quantity ;
            return totalPrice;
        }
    }
}
