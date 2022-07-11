using Atividade9.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem itens)
        {
            Itens.Add(itens);
        }

        public void RemoveItem(OrderItem itens)
        {
            Itens.Remove(itens);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.Append(Moment);
            sb.Append("Order status: ");
            sb.Append(Status);
            sb.Append("Client : ");
            sb.Append(Client.Name);
            sb.Append(Client.Birtday);

            sb.Append("Order items: ");
            
            foreach (OrderItem o in Itens)
            {

                sb.Append(o.Product); sb.Append(o.Quantity); sb.Append(o.Price);
            }
            

            return sb.ToString();
        }


       
    }
}
