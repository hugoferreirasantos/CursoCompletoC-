using System;
using System.Globalization;
using System.Threading.Tasks.Sources;

namespace ExercicioProposto04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, numeroDeHoras;
            double salario, valorHora;

            numeroFuncionario = int.Parse(Console.ReadLine());
            numeroDeHoras = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numeroDeHoras * valorHora;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}