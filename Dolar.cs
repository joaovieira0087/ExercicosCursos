class Dolar {
    public static double ValorContacao;
    public static double Valor;

    public static double ValorFinal() {
        double totalBruto = Valor * ValorContacao;
        return totalBruto + (totalBruto * 0.06);
    }
}