using System;
using System.Xml;
using System.Globalization;

namespace DateTimeExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representação interna:
            Console.WriteLine("Representação interna:");
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //Conta os Ticks desde do dia 1 de janeiro da era comun

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            //Demonstração - construtores:
            Console.WriteLine("Demonstração - construtores:");
            DateTime d1c = new DateTime(2000, 8, 15);
            DateTime d2c = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3c = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine(d1c);
            Console.WriteLine(d2c);
            Console.WriteLine(d3c);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            //Demonstração - Now, UtcNow, Today:
            Console.WriteLine("Demonstração - Now, UtcNow, Today:");
            DateTime d1d = DateTime.Now;
            DateTime d2d = DateTime.UtcNow;
            DateTime d3d = DateTime.Today;

            Console.WriteLine(d1d);
            Console.WriteLine(d2d);
            Console.WriteLine(d3d);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            //Demonstração - Parse:
            Console.WriteLine("Demonstração - Parse:");
            DateTime d1p = DateTime.Parse("2000-08-05");
            DateTime d2p = DateTime.Parse("2000-08-05 13:05:58");
            DateTime d3p = DateTime.Parse("15/08/2000");
            DateTime d4p = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d1p);
            Console.WriteLine(d2p);
            Console.WriteLine(d3p);
            Console.WriteLine(d4p);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            //Demonstração - ParseExact:
            Console.WriteLine("Demonstração - ParseExact:");
            DateTime d1pp = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
                                    CultureInfo.InvariantCulture);
            DateTime d2pp = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d1pp);
            Console.WriteLine(d2pp);

            Console.WriteLine("----------------------------------------");


        }
    }
}