﻿using System.Globalization;

namespace CorrecaoExerFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}