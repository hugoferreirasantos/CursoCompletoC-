namespace Exer01.ClasseUtilitaria
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ConverterMoeda(double cotacao, double valorDolares)
        {
            double valorComIof = valorDolares * (1 + Iof);
            return valorComIof * cotacao;
        }

    }
}
