namespace Params
{
    public static class Calculadora
    {
        public static int Suma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}
