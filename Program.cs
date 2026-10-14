using System;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento[] estc = new Estacionamento[9];

            Console.Write("Quantas vagas seram usadas: ");
            int TotalVagas = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < TotalVagas; i++)
            {
                Console.WriteLine($"Carro: #{i+1}");
                Console.Write("Placa:");
                string Placa = Console.ReadLine();
                Console.Write("Motorista:");
                string Motorista = Console.ReadLine();
                Console.Write("Vaga:");
                int Vaga = int.Parse(Console.ReadLine());
                if(Vaga < 0 || Vaga >= estc.Length)
                {
                    Console.WriteLine("não existe essa vaga");
                }
                else
                {
                    estc[Vaga] = new Estacionamento(Placa, Motorista);
                    Console.WriteLine();
                    Console.WriteLine("Quartos ocupados:");
                }
            }
            
            for(int i = 0; i < estc.Length; i++)
            {
                if(estc[i] != null)
                {
                    Console.WriteLine(i + ": " + estc[i]);
                }
            }
        }
    }
}