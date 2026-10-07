using System.Globalization;

public class Conta {

    public string NumeroConta { get; private set; }
    public string NomeUsuario { get; set; }
    public double SaldoUsuario { get; private set; }
 
    public Conta(string numero, string nomeusuario)
    {
        NumeroConta = numero;
        NomeUsuario = nomeusuario;
    }

    public Conta(string numero, string nomeusuario, double valorinicial) {
        NumeroConta = numero;
        NomeUsuario = nomeusuario;
        ValorDepositoAcumulado(valorinicial);
    }

    

    public void ValorDepositoAcumulado(double valordeposito){
        SaldoUsuario = SaldoUsuario + valordeposito;
    }

    public void ValorSaque(double valorsaque) {
        SaldoUsuario = (SaldoUsuario - valorsaque) - 5;
    }

    public override string ToString()
    {
        return "Conta: "
        + NumeroConta
        + ", Titular: "
        + NomeUsuario
        + ", Saldo: $ "
        + SaldoUsuario.ToString("F2", CultureInfo.InvariantCulture);
    }
}