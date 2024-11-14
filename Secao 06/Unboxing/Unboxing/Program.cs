using System;

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x;
            int y = (int) obj;

            Console.WriteLine(y);
            Console.WriteLine(y.GetTypeCode());
        }
    }
}