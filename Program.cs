using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            // DECLARAÇÃO DO OBJETIVO: Criamos a variável aqui fora para que ela exista no código inteiro (Escopo Global do método). 
            // O 'if/else' vai apenas dar o 'new' (instanciar) usando o construtor certo, mas a variável 'p' será a mesma até o final!
            Conta p; 


            Console.Write("Entre o número da conta:");
            string NumeroConta = Console.ReadLine();
            Console.Write("Entre o titular da conta:");
            string NomeUsuario = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char Opcao = char.Parse(Console.ReadLine().ToLower());

            if(Opcao == 's') {
                Console.Write("Entre o valor de depósito inicial:");
                double ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new Conta(NumeroConta, NomeUsuario, ValorInicial);
            }
            else {
                p = new Conta(NumeroConta, NomeUsuario);
            }

            Console.WriteLine();
            Console.Write("Dados da conta:");
            Console.WriteLine(p);

            Console.Write("Entre um valor para depósito:");
            double ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.ValorDepositoAcumulado(ValorDeposito);

            Console.WriteLine();
            Console.Write("Dados da conta atualizados:");
            Console.WriteLine(p);

            Console.Write("Entre um valor para saque:");
            double ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.ValorSaque(ValorSaque);

            Console.WriteLine();
            Console.Write("Dados da conta atualizados:");
            Console.WriteLine(p);

            Console.ReadKey();
        } 
    }
}