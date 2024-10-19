using System.Globalization;

namespace CorrecaoExerFixacao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string? Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string? titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string? titular, double depositoIncial) : this(numero, titular)
        {
            Deposito(depositoIncial);
        }

        public void Deposito(double quantia)
        {
            if (quantia > 0)
            {
                Saldo += quantia;
            }
        }

        public void Saque(double quantia)
        {
            if (quantia > 0)
            {
                Saldo -= quantia + 5.0;
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
