using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char opcao = char.Parse(Console.ReadLine());

            ContaBancaria contaBancaria;

            if (opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numeroConta, titular, deposito);
            }
            else
            {
                contaBancaria = new ContaBancaria(numeroConta, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            contaBancaria.RealizeDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            contaBancaria.RealizeSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);


        }
    }
}