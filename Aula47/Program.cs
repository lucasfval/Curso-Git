using Aula47.Entities;
using System;
using Aula47.Entities.Enum;

namespace Aula47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Costumer Data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status(PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(nome, email, date);
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many itens to this order: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} Data: ");
                Console.Write("Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Product Price: ");
                double preco = double.Parse(Console.ReadLine());
                Product product = new Product(name, preco);
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());
                
                OrderItem orderitem = new OrderItem(qty, preco, product);
                order.addOrding(orderitem);
            }
            Console.WriteLine(" ");
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
