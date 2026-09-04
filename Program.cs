using System.Globalization;
using System.Net.NetworkInformation;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            double Circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia {Circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        } 
    }
}