using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, qtd;
            double total;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            if(codigo == 1)
            {
                total = qtd * 4.00;

            }else if(codigo == 2)
            {
                total = qtd * 4.50;

            }else if (codigo == 3)
            {
                total = qtd * 5.00;

            }else if (codigo == 4)
            {
                total = qtd * 2.00;
            }else if (codigo == 5)
            {
                total = qtd * 1.50;
            }else
            {
                total = 0;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}