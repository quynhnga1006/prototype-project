using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public string Status { get; set; }

        public Order(int id, string productName, int quantity, decimal price, string status)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

        // Method to clone the current order
        public Order Clone()
        {
            return new Order(Id, ProductName, Quantity, Price, Status);
        }
    }
}