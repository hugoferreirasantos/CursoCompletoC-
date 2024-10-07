using System;
using System.Globalization;

namespace Exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fucionario1, fucionario2;

            fucionario1 = new Funcionario();
            fucionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            fucionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fucionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            fucionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            fucionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (fucionario1.Salario + fucionario2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}