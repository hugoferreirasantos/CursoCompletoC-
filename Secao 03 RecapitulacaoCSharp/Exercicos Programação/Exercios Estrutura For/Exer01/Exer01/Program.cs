using System;

namespace Exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de números impares que deseja:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numero; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}