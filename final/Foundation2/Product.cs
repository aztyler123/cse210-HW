using System;
using System.Collections.Generic;

namespace Ordermenu
{
    public class Product
    {
        private string _name;
        private string _productId;
        private decimal _pricePerUnit; //using decimal for the easier two placemant solving.
        private int _quantity;

        public Product(string name, string productId, decimal pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public string Name { get => _name; set => _name = value;}
        public string ProductId { get => _productId; set => _productId = value;}
        public decimal PricePerUnit { get => _pricePerUnit; set => _pricePerUnit = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public decimal GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }
    }   
}