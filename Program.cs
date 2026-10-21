using System;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = ["maria", "pedro", "ana"];

            for(int i =0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            foreach(string obj in vet)
            {
                Console.WriteLine(obj);
            }


            Console.ReadKey();
        }
    }
}