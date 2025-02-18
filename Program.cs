using System;
using Pedidos.Entities;
using Pedidos.Entities.Enums;

/* PROGRAMA: Lê os dados de um pedido com N Itens (N fornecido pelo usuário). Depois mostra um sumário do pedido
 Conforme UML fornecido. OBS: O instante do pedido DEVE ser o instante do sistema*/
namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();                        
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Order Data:");
            Console.WriteLine();
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); //Função principal, nada demais de pegar o status da nossa Enum
            
            Client client = new Client(name, email, birthDate);  //Instanciar cliente e pedido
            Order order = new Order(DateTime.Now, status, client);
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter Product #{i} data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());
                
                Product product = new Product(productName, price);    //Loop for básico repetindo o número necessário para cada produto
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                OrderItem orderItem = new OrderItem(quantity, price, product); //Instanciar itens do pedido
                
                order.AddItem(orderItem); //adicionar a lista 
            }
            
            Console.WriteLine();
            Console.Write("ORDER SUMMARY: ");
            Console.WriteLine(order);
            
        }
    }
}