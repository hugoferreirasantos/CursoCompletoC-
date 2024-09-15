using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int numero = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"Valor # {i} : ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}