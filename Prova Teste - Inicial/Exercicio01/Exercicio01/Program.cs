using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroPeca,NumeroPeca2, QtdPeca, QtdPeca2;
            double ValorPeca, ValorPeca2, TotalPagar;

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            NumeroPeca = int.Parse(vet1[0]);
            QtdPeca = int.Parse(vet1[1]);
            ValorPeca = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            NumeroPeca2 = int.Parse(vet2[0]);
            QtdPeca2 = int.Parse(vet2[1]);
            ValorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            TotalPagar = (QtdPeca * ValorPeca) + (QtdPeca2 * ValorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {TotalPagar.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}