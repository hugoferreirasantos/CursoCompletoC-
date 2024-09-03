using System;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ultimoNome;
            int qtdCasas, idade;
            double precoProduto, altura;


            Console.WriteLine("Entre com o seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa ?");
            qtdCasas = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o seu último nome, idade, e altura(mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            ultimoNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(qtdCasas);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{ultimoNome} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}