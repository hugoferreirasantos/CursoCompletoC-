﻿using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z, a, b, c;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine();

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}