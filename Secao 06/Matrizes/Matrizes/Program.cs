using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // retorna o tamanho da matriz: linhas x colunas:
            Console.WriteLine(mat.Rank); // retorna o número de dimenções de array:
            Console.WriteLine(mat.GetLength(0)); // retorna o número de linhas
            Console.WriteLine(mat.GetLength(1)); // retorna o número de colunas
        }
    }
}