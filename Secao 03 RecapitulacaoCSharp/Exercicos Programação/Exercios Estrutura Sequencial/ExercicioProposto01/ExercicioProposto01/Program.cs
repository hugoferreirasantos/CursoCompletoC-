using System;

namespace ExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine($"SOMA: {soma}");
        }
    }
}