using System;
using System.Globalization;

namespace Exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um codigo de um produto e a quantidade que deseja.");

            string[] vetor = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vetor[0]);
            int quantidade = int.Parse(vetor[1]);

            double totalPagar = TotalPagar(codigo, quantidade);

            Console.WriteLine($"Total: R$ {totalPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double TotalPagar(int codigo, int quantidade)
        {
            double totalPagar;

            if (codigo == 1)
            {
                totalPagar = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                totalPagar = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                totalPagar = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                totalPagar = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                totalPagar = quantidade * 1.50;
            }
            else
            {
                totalPagar = 0;
            }

            return totalPagar;
        }
    }
}