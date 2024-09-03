using System;
using System.Globalization;

namespace ExercicioProposto02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");




        }
    }
}