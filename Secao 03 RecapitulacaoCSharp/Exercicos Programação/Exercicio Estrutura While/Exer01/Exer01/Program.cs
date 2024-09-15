using System;
using System.Net.Mail;

namespace Exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("Infome um senha: ");
                int senhaDigitada = int.Parse(Console.ReadLine());
                int senha = senhaDigitada;

                if (senha == 2002)
                {
                    senha = senhaDigitada;
                    Console.WriteLine("Acesso Permitido");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                    flag = true;
                }
            }



        }
    }
}