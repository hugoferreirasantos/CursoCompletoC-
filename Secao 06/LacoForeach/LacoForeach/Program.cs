using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Bob", "Alex" };

            foreach (string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        }
    }
}