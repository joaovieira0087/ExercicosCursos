class AumentoSalario {
    public string Nome;
    public double ClienteSalario;
    public double Imposto;

    public double SalarioLiquido()
    {
        return ClienteSalario - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        ClienteSalario += ClienteSalario * (porcentagem/100.0);
    }
}

