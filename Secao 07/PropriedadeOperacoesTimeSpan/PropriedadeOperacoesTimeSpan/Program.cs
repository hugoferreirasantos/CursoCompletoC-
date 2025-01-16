using System;

namespace PropriedadeOperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Propriedades e Operações com TimeSpan

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("===================================================================");

            Console.WriteLine();

            Console.WriteLine("Demonstração: propriedade");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine();

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine();

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.Minutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilesecundos: " + t.TotalMilliseconds);

            Console.WriteLine("===========================================================");

            Console.WriteLine("Demonstração: Operações: Soma, diferença, subtração, multi, div");

            TimeSpan t1p = new TimeSpan(1, 30, 10);
            TimeSpan t2p = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1p.Add(t2p);
            TimeSpan dif = t1p.Subtract(t2p);
            TimeSpan mult = t2p.Multiply(2.0);
            TimeSpan div = t2p.Divide(2.0);

            Console.WriteLine(t1p);
            Console.WriteLine(t2p);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


        }
    }
}