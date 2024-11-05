using System;
using System.Globalization;

namespace VetorExemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine()); //Pega o tamanho do vetor

            double[] vetor = new double[tamanho]; //Instancia o vetor

            for ( int i = 0; i < tamanho; i++ )
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } //Inseri os valores nas posições do vetor 

            double soma = 0.0;

            for ( int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }//Soma os valores das alturas que estão no vetor

            double media = soma / tamanho;//Monta a media

            Console.WriteLine($"AVERAGE HEIGHT {media.ToString("F2", CultureInfo.InvariantCulture)}"); //Imprime a media

        }
    }
}