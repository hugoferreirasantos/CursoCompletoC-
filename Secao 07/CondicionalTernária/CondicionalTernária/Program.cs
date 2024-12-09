using System;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um preço: ");
            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20.0) ? preco * 0.01 : preco * 0.05;
            Console.WriteLine($"Desconto: {desconto}");
        }
    }
}