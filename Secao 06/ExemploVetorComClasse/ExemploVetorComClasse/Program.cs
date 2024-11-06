using System;
using System.Globalization;

namespace ExemploVetorComClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());

            Produto[] vetorProduto = new Produto[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetorProduto[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for ( int i = 0; i < tamanho; i++)
            {
                soma += vetorProduto[i].Preco;
            }

            double obtenhaMedia = soma / tamanho;
            Console.WriteLine($"AVERAGE PRICE = {obtenhaMedia.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}