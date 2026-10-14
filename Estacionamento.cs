public class Estacionamento
{
    public string Placa { get; set; }
    public string Motorista { get; set; }

    public Estacionamento(string placa, string motorista){
        Placa = placa;
        Motorista = motorista;
    }


    public override string ToString()
    {
       return Placa + ", " + Motorista;
    }
}