using System;
using System.Globalization;

namespace ExercicioProposto06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, pi = 3.14159;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTriangulo = a * c / 2;
            areaCirculo = pi * Math.Pow(c, 2);
            areaTrapezio = (a + b) * c / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}