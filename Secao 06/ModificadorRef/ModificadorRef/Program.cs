using System;

namespace ModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculadora.Triplique(ref a);
            Console.WriteLine(a);
        }
    }
}