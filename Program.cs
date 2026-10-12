using System;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            ProdutoVetores[] vect = new ProdutoVetores[N];

            for(int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new ProdutoVetores {Nome = name, Preco = preco};
            }

            double som = 0;
            for (int i = 0; i < N; i++)
            {
                som = som + vect[i].Preco;
            }

            double total = som / N;
            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));
        } 
    }
}