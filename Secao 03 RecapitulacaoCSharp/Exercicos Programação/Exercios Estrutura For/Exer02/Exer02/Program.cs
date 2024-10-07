using System;

namespace Exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumerosDentro = 0, quantidadeNumerosFora = 0, x = 0;
            
            Console.Write("Insira a quantidade de números que deseja digitar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    quantidadeNumerosDentro += 1;
                }
                else
                {
                    quantidadeNumerosFora += 1;
                }
            }

            Console.WriteLine($"{quantidadeNumerosDentro} in");
            Console.WriteLine($"{quantidadeNumerosFora} in");
        }
    }
}