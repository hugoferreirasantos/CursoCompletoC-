using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            bool flag = true;

            while (flag)
            {
                senha = int.Parse(Console.ReadLine());
                if(senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}