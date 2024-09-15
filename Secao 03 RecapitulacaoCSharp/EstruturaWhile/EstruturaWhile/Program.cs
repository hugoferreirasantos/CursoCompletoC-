using System;
using System.Globalization;

namespace EstruraWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"Raiz: {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.Write("Digite um número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo!");
            Console.WriteLine("Fim do Programa.");
        }
    }
}