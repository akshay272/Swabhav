
using System;
using ShoppingCartLib.Model;

namespace ConsoleShoppingCart
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer(101, "Akshay");

            Order order1 = new Order(1001, DateTime.Now);
            order1.AddItem(new LineItem(1, new Product(401, "Book", 500, 40),2 ));
            order1.AddItem(new LineItem(2, new Product(401, "BooK", 500, 50), 10));

            Order order2 = new Order(1002, DateTime.Now);
            order2.AddItem(new LineItem(1, new Product(701, "Hp Laptop", 35000, 20), 1));
            order2.AddItem(new LineItem(2, new Product(106, "Pencil", 8, 20), 10));
            order2.AddItem(new LineItem(3, new Product(108, "Color", 224, 30), 2));


            customer.AddOrder(order1);
            customer.AddOrder(order2);


            PrintDetails(customer);
            Console.ReadLine();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer : {customer.Nmae}");
            Console.WriteLine($"Number of orders : {customer.OrderCount}");

            foreach (var orderitems in customer.Order)
            {
                Console.WriteLine("###########################################################################");
                Console.WriteLine($"Order Number : {orderitems.Id}");
                Console.WriteLine($"Order Date : {orderitems.Date}");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Order Details:");
                Console.WriteLine($"Number of Lineitems  : {orderitems.ItemCount}");
                foreach (var items in orderitems.Items)
                {
                    Console.WriteLine($"\t\tLineItem id : {items.Id}");
                    Console.WriteLine($"\t\t-Product id : {items.Product.Id}");
                    Console.WriteLine($"\t\t-Product Name : {items.Product.Name}");
                    Console.WriteLine($"\t\t-Product Price : {items.Product.Price}");
                    Console.WriteLine($"\t\t-Discounted Price : {items.Product.Discount}");
                    Console.WriteLine($"\t\t-Quantity : {items.Quantity}");
                    Console.WriteLine($"LineItem total price : {items.Calculate()}");
                }
                Console.WriteLine($"Order Total : {orderitems.GetOrderTotal()}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"Total of customer {customer.Nmae} is {customer.CustomerTotal()}");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine(" ");
        }
    }
}