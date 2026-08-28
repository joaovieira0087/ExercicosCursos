using System.Globalization;

class Produto {
    public string Nome;
    public int Quantidade;
    public double Preco;

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
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