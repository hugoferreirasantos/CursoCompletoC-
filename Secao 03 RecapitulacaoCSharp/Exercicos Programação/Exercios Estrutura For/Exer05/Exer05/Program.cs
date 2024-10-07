using System;

namespace Exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o fatoria que deseja: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}