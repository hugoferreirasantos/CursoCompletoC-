using System;
using System.Globalization;

namespace Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X : {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y : {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
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