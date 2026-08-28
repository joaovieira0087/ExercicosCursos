
using System.Globalization;

Produto p = new Produto();


Console.Write("Entre os dados do produto");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco do Produto: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());
Console.WriteLine(p);

