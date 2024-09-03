using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Informe 2 numeros inteiros, para verificar se são mulpliplos ou não:");
            string[] vet = Console.ReadLine().Split(' ');

            numero1 = int.Parse(vet[0]);
            numero2 = int.Parse(vet[1]);

            if(numero1 % numero2 == 0 || numero2 % numero1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}