using System;
using System.Xml;

namespace TotalizadorDeHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalHoras = 0;
            int totalMinutos = 0;

            Console.Write("Quantidade vezez deseja somar ? : ");
            int qtdHoras = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < qtdHoras; i++)
            {
                Console.Write("Informe a hora: ");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Informe o minuto: ");
                int minuto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                // Adiciona as horas informadas
                totalHoras += hora;
                totalMinutos += minuto;

                // Converte os minutos para horas (se 60 minutos = 1 hora) e adiciona ao total
                totalHoras += totalMinutos / 60;
                totalMinutos = totalMinutos % 60;
            }

            Console.WriteLine();

            Console.WriteLine($"{totalHoras} horas e {totalMinutos} minutos");


        }
    }
}