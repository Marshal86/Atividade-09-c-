using System;
using Atividade9.Entities;
using Atividade9.Entities.Enum;

namespace Atividade9
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Enter cliente data: ");
            Console.WriteLine();
            Console.Write("Name ");
            string nome = Console.ReadLine();
            Console.Write("E-mail ");
            string email = Console.ReadLine();
            Console.Write("Birthday ");
            DateTime aniversario = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(nome, email, aniversario);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order ?");
            int quantidade = int.Parse(Console.ReadLine());

            Order pedido = new Order(DateTime.Now, os, cliente);


            for (int i = 1; i<=quantidade; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Produto ");
                string pnome = Console.ReadLine();
                Console.Write("Preço ");
                double ppreco = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade");
                int pquantidade = int.Parse(Console.ReadLine());

                Product produto = new Product(pnome, ppreco);
                OrderItem item = new OrderItem(pquantidade, ppreco, produto);
                

                pedido.AddItem(item);
                

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(pedido);






        }
    }
}
