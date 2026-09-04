using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome: ");
aluno.AlunoNome = Console.ReadLine();
Console.Write("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double NotaFInal = aluno.NotaFinalAluno();
Console.WriteLine($"NOTA FINAL = {NotaFInal.ToString("F2", CultureInfo.InvariantCulture)}");
string Decisao = aluno.NotaAlunoDecisao(NotaFInal);
Console.WriteLine(Decisao);

if (NotaFInal < 60) {
    double Faltam = aluno.Restante(NotaFInal);
    Console.WriteLine($"FALTARAM {Faltam.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
}



