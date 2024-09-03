using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2"));
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2")} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");


        }
    }
}