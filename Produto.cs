using System.Globalization;
using System.Net.NetworkInformation;
using System;

public class Produto {
    public string Nome;
    public int Quantidade;
    public double Preco;

    public Produto(int quantidade)
    {
        Quantidade = quantidade + 10;
    }

    
    public Produto(string nome, double preco, int quantidade) : this(quantidade) {
        Nome = nome;
        Preco = preco;
    }

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade) {
        Quantidade = Quantidade + quantidade;
    }

     public void RemoverProduto(int quantidade) {
        Quantidade = Quantidade - quantidade;
    }

    public override string ToString()
    {
        return Nome 
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", " 
        + Quantidade
        + " Unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }


}
