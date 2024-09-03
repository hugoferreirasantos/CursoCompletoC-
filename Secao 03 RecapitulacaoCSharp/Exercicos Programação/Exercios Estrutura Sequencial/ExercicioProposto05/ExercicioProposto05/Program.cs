using System;
using System.Globalization;

namespace ExercicioProposto05
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, numeroPecas1,codigoPeca2, numeroPecas2;
            double valorUnitarioPeca1, valorUnitarioPeca2, totalPagar;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');
            
            codigoPeca1 = int.Parse(vet[0]);
            numeroPecas1 = int.Parse(vet[1]);
            valorUnitarioPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            codigoPeca2 = int.Parse(vet2[0]);
            numeroPecas2 = int.Parse(vet2[1]);
            valorUnitarioPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            totalPagar = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}