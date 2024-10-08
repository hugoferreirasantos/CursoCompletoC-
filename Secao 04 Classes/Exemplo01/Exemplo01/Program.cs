﻿using System;
using System.Globalization;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (xA + xB + xC) / 2.0;
            double areaY = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            Console.WriteLine($"Área de X : {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y : {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}