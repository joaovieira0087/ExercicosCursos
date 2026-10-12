using System;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace ExerciciosPropostos {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            double[] vect = new double[N];

            for(int i = 0; i < N; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < N; i++)
            {
                sum = sum + vect[i];
            }

            double total = sum / N;
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
        } 
    }
}