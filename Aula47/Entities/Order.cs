using Aula47.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Aula47.Entities
{
    class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Ording { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void addOrding(OrderItem ording)
        {
            Ording.Add(ording);
        }
        public void removeOrding(OrderItem ording)
        {
            Ording.Remove(ording);
        }
        public double Total()
        {
            double soma = 0;
            foreach(OrderItem ording in Ording)
            {
                soma += ording.subTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            
            foreach (OrderItem item in Ording)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }

    }
}
