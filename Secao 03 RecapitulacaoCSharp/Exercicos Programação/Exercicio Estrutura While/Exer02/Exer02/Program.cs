using System;

namespace Exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int x, y;

            while (flag)
            {
                Console.Write("Digite o valor de X e Y: ");
                string[] vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

                if (x >= 1 && y >= 1)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x <= -1 && y >= 1)
                {
                    Console.WriteLine("segundo");
                }
                else if (x <= -1 && y <= -1)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x >= 1 && y <= -1)
                {
                    Console.WriteLine("quarto");
                }
                else if (x == 0 || y == 0)
                {
                    Console.WriteLine("");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("");
                    flag = false;
                }
            }
        }
    }
}