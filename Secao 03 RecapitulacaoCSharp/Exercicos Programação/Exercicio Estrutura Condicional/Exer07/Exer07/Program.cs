using System;
using System.Globalization;

namespace Exer07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe os eixos X e Y: ");
            string[] vetor = Console.ReadLine().Split(' ');
            double eixoX = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double eixoY = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            string quandrante = RetornarInformaQuadrante(eixoX, eixoY);

            Console.WriteLine(quandrante);

        }

        static string RetornarInformaQuadrante(double x, double y)
        {
            string resultado;

            if (x >= 1 && y >= 1)
            {
                resultado = "Q1";
            }
            else if(x <= -1 && y >= 1)
            {
                resultado = "Q2";
            }
            else if (x <= -1 && y <= -1)
            {
                resultado = "Q3";
            }
            else if (x >= 1 && y <= -1)
            {
                resultado = "Q4";
            }
            else
            {
                resultado = "Origem";
            }

            return resultado;
        }
    }
}