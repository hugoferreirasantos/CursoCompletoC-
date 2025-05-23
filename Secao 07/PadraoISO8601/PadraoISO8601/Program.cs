﻿using System;

namespace PadraoIso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime

            Console.WriteLine($"d1 = {d1}");
            Console.WriteLine($"d1 kind = {d1.Kind}");
            Console.WriteLine($"d1 to local  = {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to Utc  = {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d2 = {d2}");
            Console.WriteLine($"d2 kind = {d2.Kind}");
            Console.WriteLine($"d2 to local = {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to Utc = {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));// cuidado
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}