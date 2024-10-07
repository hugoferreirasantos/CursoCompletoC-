using System;
using System.Globalization;

namespace Exer03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantidade de vezes que desaja fazer a média ponderada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                double numero01 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double numero02 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double numero03 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (numero01 * 2.0 + numero02 * 3.0 + numero03 * 5.0) / 10.0;
                Console.WriteLine($"{mediaPonderada.ToString("F1", CultureInfo.InvariantCulture)}");

            }

        }
    }
}