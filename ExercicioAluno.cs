using System;
using System.Globalization;

namespace ExerciciosPropostos {
    public class ExercicioAluno {
        public static void Executar() {
            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.AlunoNome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinalAluno().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.NotaAlunoDecisao()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.Restante().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}