using System;
using System.Globalization;

namespace Exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de vezes que deseja realizar divições: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= numero; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                int numero01 = int.Parse(linha[0]);
                int numero02 = int.Parse(linha[1]);

                if (numero02 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)numero01 / numero02;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}