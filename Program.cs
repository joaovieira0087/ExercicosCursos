
using System.Globalization;

Produto p = new Produto();


Console.Write("Entre os dados do produto");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco do Produto: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(p);
Console.WriteLine();

Console.Write("digite o numero de produtos a ser add: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: " + p );
Console.WriteLine();
Console.Write("digite o numero de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProduto(qte);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: " + p );
Console.WriteLine();


