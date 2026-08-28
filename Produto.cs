class Produto {
    public string Nome;
    public int Quantidade;
    public double Preco;

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }
}