using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont = 0, cont2 = 0;
            int[] vet;

            N = int.Parse(Console.ReadLine());

            vet = new int[N];

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < N; ++i)
            {
                if (vet[i] >=10 && vet[i] <= 20)
                {
                    cont++;
                }
                else
                {
                    cont2++;
                }
            }

            Console.WriteLine($"{cont} in");
            Console.WriteLine($"{cont2} out");

        }
    }
}