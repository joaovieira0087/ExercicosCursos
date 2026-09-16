using System.Globalization;
using System.Net.NetworkInformation;
using System;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do pedido");
            Console.WriteLine("Nome");
            string Nome = Console.ReadLine();
            Console.WriteLine("Quantidade");
            int Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preco");
            double Preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);


            Console.ReadKey();
        }
    }
}