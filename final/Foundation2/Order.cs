using System;
using System.Collections.Generic;

namespace Ordermenu
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public List<Product> Products {get => _products; set => _products = value; } //get what they want and then find the price and quantity we have left
        public Customer Customer { get => _customer; set => _customer = value; }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal CalculateTotalCost()
        {
            decimal totalProductCost = 0;
            foreach (Product product in _products)
            {
                totalProductCost += product.GetTotalCost();
            }
            
            decimal shippingCost = _customer.LivesInUsa() ? 5.00m : 35.00m; //speccifications are necessary

            return totalProductCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "-------Packing Label (If broken call immediately)-----------\n";
            foreach (Product product in _products)
            {
                label += ($"ID: {product.ProductId} | Name: {product.Name} (Quantity: {product.Quantity})\n");
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "------Shipping Label--------\n";
            label += ($"{_customer.Name}");
            label += _customer.Address.GetFullAddressString() + "\n";
            return label;
        }
    }
}