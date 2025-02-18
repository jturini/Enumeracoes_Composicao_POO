using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entities.Enums;


namespace Pedidos.Entities 
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }  //Definindo propriedades
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); //Criação da Lista

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
                                                    //Construtores
        public Order()
        {
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)       //Funções de adicionar e remover itens, não usei o remover no código principal, mas poderia ser utilizado
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();      //Cáclulo do subtotal EX: 2 mouses a $40 = $80
            }
            return sum;
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);      
            sb.AppendLine("Client: "+ Client);  /*  Concatenando strings sem criar novas instâncias na memória, e representando nossos OBJ como strings*/
            sb.AppendLine("Items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString()); // pra cada item da nossa lista,adiciona a representacao em texto ao stringbuilder
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
        
    }
}

