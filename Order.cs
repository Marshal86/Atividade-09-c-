using Atividade9.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

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

        public double Total()
        {
            double soma = 0.0;
            foreach(OrderItem item in Itens)
            {
                
                soma += soma + item.SubTotal();
            }
            return soma;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order Moment : " + Moment.ToString("G"));
            sb.AppendLine("Order status : " + Status);
            sb.AppendLine("Client : " + Client);
            sb.AppendLine("Order items : ");

            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
                
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));



            return sb.ToString();
        }


       
    }
}
