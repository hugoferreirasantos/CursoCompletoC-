using System.Globalization;

namespace ExercicioFixacao
{
    class ContaBancaria
    {
        private int _numeroConta;
        private double _taxaSaque = 5.0;
        public string? Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            _numeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            _numeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }


        public void RealizeDeposito(double quantia)
        {
            Saldo += quantia;
        }

        public void RealizeSaque(double quantia)
        {
            Saldo -= (quantia + _taxaSaque);
        }

        public override string ToString()
        {
            return $"Conta: {_numeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InstalledUICulture)}";
        }

    }
}
