﻿using System;

namespace PropriedadeOperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo:
            DateTime d = new DateTime(2008, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " +  d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kink: " + d.Kind);
            Console.WriteLine("7) Millesecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year) ;

            Console.WriteLine("===============================================================");

            DateTime dn = new DateTime(2008, 8, 15, 13, 45, 58, 275);

            string s1 = dn.ToLongDateString();
            string s2 = dn.ToLongTimeString();
            string s3 = dn.ToShortDateString();
            string s4 = dn.ToShortTimeString();
            string s5 = dn.ToString();
            string s6 = dn.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = dn.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}