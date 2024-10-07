using System.Globalization;
using Exer01.ClasseUtilitaria;

namespace Exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double valorCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valorEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ConverterMoeda(valorCotacao,valorEmDolar).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}