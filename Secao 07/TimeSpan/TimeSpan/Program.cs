using System;
using System.Dynamic;

namespace TimeSpanExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de instanciação utilizando TimeSpan:
            TimeSpan t1pri = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1pri);
            Console.WriteLine(t1pri.Ticks + "  - Tikis");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Demonstração - Construtores:");

            //Demonstração - Construtores:
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();

            //Demonstração - Métodos From:
            Console.WriteLine("Demonstração - Métodos From:");

            TimeSpan t1m = TimeSpan.FromDays(1.5);
            TimeSpan t2m = TimeSpan.FromHours(1.5);
            TimeSpan t3m = TimeSpan.FromMinutes(1.5);
            TimeSpan t4m = TimeSpan.FromSeconds(1.5);
            TimeSpan t5m = TimeSpan.FromMicroseconds(1.5);
            TimeSpan t6m = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1m);
            Console.WriteLine(t2m);
            Console.WriteLine(t3m);
            Console.WriteLine(t4m);
            Console.WriteLine(t5m);
            Console.WriteLine(t6m);

            Console.WriteLine();

        }
    }
}