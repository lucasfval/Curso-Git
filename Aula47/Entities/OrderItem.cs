using System;
using System.Collections.Generic;
using System.Text;

namespace Aula47.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double subTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + subTotal().ToString("F2");
        }
    }
}
