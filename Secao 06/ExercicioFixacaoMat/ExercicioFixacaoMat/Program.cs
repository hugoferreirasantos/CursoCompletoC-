using System;

namespace ExercicioFixacaoMatize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int n = int.Parse(vet[0]); // número de linhas
            int m = int.Parse(vet[1]); // número de colunas

            int[,] mat = new int[n, m]; // instanciando a matriz

            // Inserindo valores dentro da matriz
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();

            int target = int.Parse(Console.ReadLine()); // Pegando o número para pesquisar dentro da matriz

            Console.WriteLine();

            // Localizando o número na matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == target)
                    {
                        Console.WriteLine($"Position {i},{j}:");

                        // Esquerda
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }

                        // Direita
                        if (j < m - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }

                        // Acima
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }

                        // Abaixo
                        if (i < n - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
