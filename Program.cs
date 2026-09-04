using System.Globalization;

AumentoSalario Salario = new AumentoSalario();

Console.Write("Nome: ");
Salario.Nome = Console.ReadLine();
Console.Write("Salario: ");
Salario.ClienteSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
Salario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double SemImposto = Salario.SalarioLiquido();
Console.WriteLine($"Funcionário: {Salario.Nome} ${SemImposto.ToString("F2", CultureInfo.InvariantCulture)}");
Console.Write("Digite a porcentagem para aumentar o salário:");
double AumentoSalario =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Salario.AumentarSalario(AumentoSalario);
Console.WriteLine($"Dados atualizados: {Salario.Nome}, $ {Salario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");


