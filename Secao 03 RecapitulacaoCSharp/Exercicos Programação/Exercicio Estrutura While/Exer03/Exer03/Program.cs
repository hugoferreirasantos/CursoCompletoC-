using System;

namespace Exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int codigo = 0, quantClientesAlcool = 0, quantClientesGasolina = 0, quantClientesDiesel = 0;

            Console.WriteLine("Informe um código:");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");

            Console.WriteLine();

            while (flag)
            {
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    quantClientesAlcool += 1;
                    flag = true;
                }
                else if (codigo == 2)
                {
                    quantClientesGasolina += 1;
                    flag |= true;
                }
                else if (codigo == 3)
                {
                    quantClientesDiesel += 1;
                    flag |= true;
                }
                else if (codigo == 4)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }

            }

            Console.WriteLine();

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {quantClientesAlcool}");
            Console.WriteLine($"Gasolina: {quantClientesGasolina}");
            Console.WriteLine($"Diesel: {quantClientesDiesel}");
        }
    }
}