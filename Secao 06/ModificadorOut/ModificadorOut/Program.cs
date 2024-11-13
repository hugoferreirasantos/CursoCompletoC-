using System;

namespace ModificadorOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;
            Calculadora.Triplique(a, out triplo);
            Console.WriteLine(triplo);
        } 
    }
}