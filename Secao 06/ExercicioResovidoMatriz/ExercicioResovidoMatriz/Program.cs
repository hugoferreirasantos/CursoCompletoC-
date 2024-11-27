﻿using System;

namespace ExercicioResolvidoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n]; //Instanciando a matriz

            //Inserindo valores dentro da matriz:
            for ( int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for ( int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Mostrando os valores da diagonal principal:
            Console.WriteLine("Main diagonal: ");
            for ( int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();

            //Contabilizando os valores negativo:
            int count = 0;
            for ( int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Negative numbers: {count}");

        }
    }
}