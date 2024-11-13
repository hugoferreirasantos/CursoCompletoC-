using System;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int reserva = int.Parse(Console.ReadLine());

            Aluguel[] quartos = new Aluguel[10];

            for ( int i = 1; i <= reserva; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto] = new Aluguel(nome, email, quarto);

            }

            Console.WriteLine();

            for ( int i = 0; i < 10; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine($"{i} : {quartos[i]}");
                }
            }


        }
    }
}