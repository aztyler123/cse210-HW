using System;
using System.Collections.Generic;


namespace Ordermenu
{
    class Program //does each need to have a program.cs or can I call it what I want?
    {
        static void Main(string[] args)
        {
            Address usaAddress = new Address("1727 North Ashbrook Circle", "Mesa", "AZ", "USA\n");
            Address internationalAddress = new Address("456 Manchester Way", "London", "England", "UK\n");

            Customer cust1 = new Customer("Jason Day ", usaAddress);
            Customer cust2 = new Customer("Justin Bieber ", internationalAddress);


            //making separate orders
            Product p1 = new Product("Wireless Headphones", "H420", 30.50m, 4);
            Product p2 = new Product("Mechanized Bull", "M202", 200.25m, 1);
            Product p3 = new Product("Laptop Stand", "S404", 29.99m, 1);
            
            
            //Order #2
            Product p4 = new Product("Smart Television", "T325", 135.87m, 3);
            Product p5 = new Product("HDMi Cable", "C303", 8.99m, 3);

            //specify orders
            Order order1 = new Order(cust1);
            order1.AddProduct(p1);
            order1.AddProduct(p2);
            order1.AddProduct(p3);

            Order order2 = new Order(cust2);
            order2.AddProduct(p4);
            order2.AddProduct(p5);


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             Order 1                   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total order cost: ${order1.CalculateTotalCost():F2} ");
            

            //order 2
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             Order 2                   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total order cost: ${order2.CalculateTotalCost():F2} ");

            Console.ReadLine();
        }
    }
}