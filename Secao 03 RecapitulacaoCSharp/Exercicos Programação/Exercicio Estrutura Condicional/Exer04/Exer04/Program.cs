using System;

namespace Exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);

            int duracao = CacularHora(horaInicial, horaFinal);

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");


        }

        static int CacularHora(int horaInicial, int horaFinal)
        {
            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            return duracao;
        }
    }
}